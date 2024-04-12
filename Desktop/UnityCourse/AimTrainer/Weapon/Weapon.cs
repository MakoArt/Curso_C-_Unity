using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
    [SerializeField] Canvas2 canvas2;
   
    Transform cameraTransform;
    public AudioSource pistol;
    public AudioSource automatic;
    public ParticleSystem shootParticleHead;
    GameObject[] emptyObject;
    

    private void Awake()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    private void ShootFunction()
    {
        RaycastHit hit;
        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, 100))
        {
            if (hit.collider.name == "Sphere")
            {
                canvas2.shoot += 1;
                shootParticleHead.transform.position=hit.point;
                shootParticleHead.Play();
                Destroy(hit.collider.gameObject);
              
            }
            else
            {
                canvas2.fails += 1;
             
            }

            Debug.Log(hit.collider.name);
        }

        emptyObject = GameObject.FindGameObjectsWithTag("Empties");

        for (int i = 0; i < emptyObject.Length; i++)
        {
            if (emptyObject[i].transform.childCount == 0) Destroy(emptyObject[i]);
        }
    }


    void Update()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        if (Input.GetMouseButtonDown(0) )
        {
            ShootFunction();
            pistol.Play();

        }


    }
}
