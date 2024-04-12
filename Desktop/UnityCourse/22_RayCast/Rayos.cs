using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayos : MonoBehaviour
{

    private void Shoot()
    {
        RaycastHit hit; 
        if(Physics.Raycast(transform.position,transform.up,out hit, 1000f))
        {   
            Debug.Log(hit.collider.name);
            Debug.Log(hit.point);

            if (hit.collider.name == "Wall")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.up * 1000f);
    }



}
