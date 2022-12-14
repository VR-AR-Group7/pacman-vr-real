using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public GameObject ghost1;
    public GameObject ghost2;
    public float range = 5;
    public GameObject ImpactSoundObject;
    private bool jumpscare1 = false;
    private bool jumpscare2 = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

        if(Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if(hit.collider.tag == "ghost")
            {
                print("Ghost!!");
                ghost1.SetActive(false);
                if (!jumpscare1)
                { 
                    Vector3 PointOfImpact = hit.point;
                    Instantiate(ImpactSoundObject, PointOfImpact, Quaternion.identity);
                    jumpscare1 = true;
                }             
            }
            if(hit.collider.tag == "ghostR")
            {
                print("Ghost!!");
                ghost2.SetActive(false);
                if (!jumpscare2)
                {
                    Vector3 PointOfImpact = hit.point;
                    Instantiate(ImpactSoundObject, PointOfImpact, Quaternion.identity);
                    jumpscare1 = true;
                }
            }
        }
    }
}
