using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameKeem : MonoBehaviour
{
    public GameOverKeem gameOverKeem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Ghost").Length == 0){
            Debug.Log("You Win!");
            GameOver();

        }
    }
    public void GameOver(){
        Debug.Log("Game Over");
        gameOverKeem.Setup();
    }
}
