using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerKeem : MonoBehaviour
{
    public Collider collider;
    public bool isVulnerable = false;
    // Start is called before the first frame update
    void Start()
    {
        // collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Consumable")
        {
            ConsumableKeem _consumable = other.gameObject.GetComponent<ConsumableKeem>();
            Debug.Log("Consumable entered");
            
            _consumable.Consume();
            _consumable.isConsumed = true;
            Debug.Log("_consumable.isConsumed");
            Destroy(other.gameObject);
            isVulnerable = true;
        }
    }
}
