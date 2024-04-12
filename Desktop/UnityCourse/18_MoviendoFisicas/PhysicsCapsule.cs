using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCapsule : MonoBehaviour
{
    float x;
    float z;
    float mouseX;
    [SerializeField] float jumpForce;
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
    Rigidbody rb;
    Vector3 move;




    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

 
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        mouseX = Input.GetAxis("Mouse X");

        move = new Vector3(x, 0, z);

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
        }
   
    }

    private void FixedUpdate()
    {
      
        rb.AddRelativeForce(move * speed * Time.fixedDeltaTime,ForceMode.Force);
        rb.AddRelativeTorque(Vector3.up * rotationSpeed * mouseX *  Time.fixedDeltaTime, ForceMode.Force);
        
    
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.name == "Enemy")
    //    {
    //        gameObject.GetComponent<Renderer>().material.color = Color.red;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.collider.name == "Enemy")
    //    {
    //        gameObject.GetComponent<Renderer>().material.color = Color.green;
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("House"))
    //    {
    //        gameObject.GetComponent<Renderer>().material.color = Color.red;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("House"))
    //    {
    //        gameObject.GetComponent<Renderer>().material.color = Color.green;
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("House"))
        {
            Debug.Log("Estoy Dentro");
            rb.AddRelativeTorque(Vector3.up * rotationSpeed  * Time.fixedDeltaTime, ForceMode.Force);
        }
    
    }



}
