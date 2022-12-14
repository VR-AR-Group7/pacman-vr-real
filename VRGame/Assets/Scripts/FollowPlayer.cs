using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float wanderTimer;
    public float wanderRadius;
    public NavMeshAgent agent;
    private float timer;
    public GameObject ghost;
    public float distanceFromPlayer;

    public AudioSource chaseMusic;
    public AudioSource killMusic;

    public EndGameKeem endGameKeem;




    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        PlayerControllerKeem player_obj = player.GetComponent<PlayerControllerKeem>();

        Vector3 positionFromPlayer = player.position - transform.position;

        // make ghost vulnerable for 5 seconds
        if (player_obj.isVulnerable == true){
            chaseMusic.Play();
            StartCoroutine(WaitForIt());
            Debug.Log("Ghost is vulnerable");
            IEnumerator WaitForIt(){
                yield return new WaitForSeconds(10);
                chaseMusic.Stop();
                Debug.Log("Ghost is no longer vulnerable");
                player_obj.isVulnerable = false;
            }


        }

        if (positionFromPlayer.magnitude < distanceFromPlayer)
        {
            Vector3 direction = player.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            agent.SetDestination(player.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
        else if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }   

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }

    void OnCollisionEnter(Collision other) {
        PlayerControllerKeem player_obj = player.GetComponent<PlayerControllerKeem>();
        if (other.gameObject.tag == "Player" && player_obj.isVulnerable == false){
            Debug.Log("Game Over");
            endGameKeem.GameOver();

        }
        else if (other.gameObject.tag == "Player" && player_obj.isVulnerable == true){
            Debug.Log("Ghost is consumed");
            killMusic.Play();
            Destroy(ghost);

        }
    }
}
