using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnterCollider : MonoBehaviour
{
    public BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ghost")
        {
            boxCollider.enabled = false;
        }
        else if(other.gameObject.tag == "Player")
        {
            boxCollider.enabled = true;
        }
    }
}
