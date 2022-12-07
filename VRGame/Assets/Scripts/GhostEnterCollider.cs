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

    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Ghost")
    //     {
    //         Debug.Log("Ghost entered");
    //         boxCollider.enabled = false;
    //     }
    //     else {
    //         boxCollider.enabled = true;   
    //     }
    //     boxCollider.enabled = true;
    // }

}
