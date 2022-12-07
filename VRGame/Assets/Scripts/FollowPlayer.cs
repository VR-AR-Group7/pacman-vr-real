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
        

        Vector3 positionFromPlayer = player.position - transform.position;
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
}
