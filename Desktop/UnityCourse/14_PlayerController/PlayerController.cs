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
   // [SerializeField] Animator animator;
    [SerializeField] float counter = 0;
    [SerializeField] float timer;
     bool endKick = true;

    Vector3 vel;
    bool isGrounded;

    private void Start()
    {
        
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


        //     //SALTO ANIMATION
        //     if (Input.GetButtonDown("Jump") && isGrounded)
        //     {
        //         vel.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        //         isGrounded = false;
        //         animator.SetLayerWeight(1, 1);
        //         animator.SetTrigger("Jump");
        //         StartCoroutine(ChangeLayerCoroutine(1));

        //     }
        //     if(isGrounded) animator.SetTrigger("StopJump");





        //     vel.y += gravity * Time.deltaTime;
        //     characterController.Move(vel * Time.deltaTime);

        //     //ANIMACIONES DE MOVIMIENTO 

        //     animator.SetFloat("xVelocity", x);

        //     //RUN AND WALK 

        //     if (z <= 0)
        //     {
        //         animator.SetFloat("yVelocity", z);
        //     }
        //     else if (z > 0 && Input.GetKey(KeyCode.LeftShift))
        //     {
        //         animator.SetFloat("yVelocity", z);
        //         speed = 8;
        //     }
        //     else if (z > 0 && !Input.GetKey(KeyCode.LeftShift))
        //     {
        //         animator.SetFloat("yVelocity", 0.4f);
        //         speed = 4;
        //     }

        //     //KICK 

        //     if(Input.GetMouseButtonDown(0)) 
        //     {
        //         if (endKick)
        //         {
        //             animator.SetLayerWeight(1, 1);
        //             animator.SetTrigger("Kick");
        //             StartCoroutine(ChangeLayerCoroutine(0.5f));
        //             endKick = false;
        //         }




        //     }


        //}



        // IEnumerator ChangeLayerCoroutine(float time)
        // {
        //     yield return new WaitForSeconds(time);
        //     animator.SetLayerWeight(1, 0);
        //     animator.SetTrigger("StopKick");
        //     endKick = true;
        //     StopCoroutine(ChangeLayerCoroutine(time));
        // }
    }

}
