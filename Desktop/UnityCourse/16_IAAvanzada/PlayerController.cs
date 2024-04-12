using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask layerMaskGround;
    [SerializeField] public float speed = 4f;
    [SerializeField] float jumpForce = 4;
    [SerializeField] float gravity = -20f;
    [SerializeField] float distanceGround = 0.5f;
    [SerializeField] public Animator animator;
    [SerializeField] float counter = 0;
    [SerializeField] float timer;
    [SerializeField] GameObject sword;
    [SerializeField] public GameObject shield;



    bool endAttack = true;
    bool endJump = true;
   public bool endBlock = true;

    Vector3 vel;
    bool isGrounded;



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


        //SALTO ANIMATION
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            if (endJump)
            {
                vel.y = Mathf.Sqrt(jumpForce * -2 * gravity);
                animator.SetLayerWeight(1, 1);
                animator.SetTrigger("Jump");
                StartCoroutine(ChangeLayerCoroutine(1f));
                endJump = false;
            }
           

        }






        vel.y += gravity * Time.deltaTime;
        characterController.Move(vel * Time.deltaTime);


        //ANIMACIONES DE MOVIMIENTO 

        //RUN AND WALK 
        //vertical movement 
        if(z <= 0)
        {
            animator.SetFloat("yVelocity", z);
        }
        else if (z > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetFloat("yVelocity", z);
            speed = 8;
        }
        else if (z > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetFloat("yVelocity", 0.4f);
            speed = 4;
        }
        //horizontal movement 

        animator.SetFloat("xVelocity", x);

        //ATTACK 

        if (Input.GetMouseButtonDown(0))
        {
            if (endAttack)
            {
                sword.GetComponent<Collider>().enabled = true;
                animator.SetLayerWeight(1, 1);
                animator.SetTrigger("Attack");
                StartCoroutine(ChangeLayerCoroutine(1f));
                endAttack = false;
            }
         
        }

        //BLOCK 

        if (Input.GetMouseButtonDown(1))
        {
            if (endBlock)
            {
                shield.GetComponent<Collider>().enabled = true;
                animator.SetLayerWeight(1, 1);
                animator.SetTrigger("Block");
                StartCoroutine(ChangeLayerCoroutine(1f));
                endBlock = false;
                //Debug.Log("ESTOY BLOQUEANDOOOOO");
            }

        }

    }


    IEnumerator ChangeLayerCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        animator.SetLayerWeight(1, 0);
        sword.GetComponent<Collider>().enabled = false;
        shield.GetComponent<Collider>().enabled = false;
        endAttack = true;
        endJump = true;
        endBlock = true;
        StopCoroutine(ChangeLayerCoroutine(time));

    }

}
