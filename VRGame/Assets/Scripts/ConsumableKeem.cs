using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableKeem : MonoBehaviour
{
    public bool isConsumed = false;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Consume(){
        Debug.Log("Consumed");
        audioSource.Play();
        isConsumed = true;
    }
}
