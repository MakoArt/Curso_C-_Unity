using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 [SerializeField] CharacterController characterController;
 [SerializeField] Transform groundCheck;
 [SerializeField] LayerMask layerMaskGround;
 [SerializeField] float speed = 4f;
 [SerializeField] float jumpForce = 4;
 [SerializeField] float gravity = -20f;
 [SerializeField] float distanceGround = 0.5f;
 [SerializeField] float counter = 0;
 [SerializeField] float timer;


 Vector3 vel;
 bool isGrounded;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, distanceGround, layerMaskGround);

        if (isGrounded && vel.y < 0)
        {
            vel.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);


        //SALTO 
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            vel.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }



        vel.y += gravity * Time.deltaTime;
        characterController.Move(vel * Time.deltaTime);


    }

    }
