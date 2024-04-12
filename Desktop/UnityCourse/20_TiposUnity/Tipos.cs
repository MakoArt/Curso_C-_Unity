using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tipos : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] Transform cubeTransform;
    [SerializeField] Vector3 cubeVector3;
    [SerializeField] Renderer cubeRenderer;
    [SerializeField] Material cubeMaterial;
    [SerializeField] Quaternion cubeRotation;

    GameObject hijo1;
 

    void Start()
    {

        //Debug.Log(cube.activeInHierarchy);
        //Debug.Log(cube.name);
        //Debug.Log(cube.CompareTag("Player"));
        //Debug.Log(cube.transform.localScale);
        //Debug.Log(cube.transform.position);
        //Debug.Log(cube.transform.rotation);
        //GameObject hijo1 =  cube.transform.GetChild(0).gameObject;

        ////hijo1.GetComponent<Renderer>().material.color = Random.ColorHSV();
        ////hijo1.transform.localScale += new Vector3(0, 3, 0);

        // cube.transform.GetChild(1).gameObject.SetActive(false);

        cubeTransform.position = new Vector3(0,0,0);
        cubeTransform.localScale = new Vector3(1,1,1);
        cubeTransform.localRotation = Quaternion.Euler(45,0,0);
            

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
