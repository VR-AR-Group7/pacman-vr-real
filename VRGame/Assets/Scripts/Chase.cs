using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField] public GameObject ghost;
    [SerializeField] public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        ghost.SetActive(false);
        door.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        ghost.SetActive(true);
        door.SetActive(true);
    }
}
