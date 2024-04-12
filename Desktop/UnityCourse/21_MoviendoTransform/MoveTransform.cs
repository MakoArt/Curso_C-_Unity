using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Renderer cilynderRenderer;
    [SerializeField] float speedRotation;
    [SerializeField] float speed;
    public enum CilynderState { FORWARD,BACKWARD,RIGHT,LEFT,UP,DOWN}
    public CilynderState cilynderState;



    private void Start()
    {
        StartCoroutine(ChangeDirectionCoroutine());
    }
     

    private void MoveFunction(Vector3 myVector)
    {
        playerTransform.position += myVector;
  
    }


    void Update()
    {
        //playerTransform.position += new Vector3(0, 1f * Time.deltaTime, 2f * Time.deltaTime);
        //// playerTransform.localRotation *= Quaternion.Euler(0, 0, 0.4f );
        //playerTransform.Rotate(Vector3.forward * speedRotation * Time.deltaTime);

        switch(cilynderState) 
        {
            case CilynderState.FORWARD:
               MoveFunction(new Vector3(0,0,1 * speed * Time.deltaTime)); 
                break;
            case CilynderState.BACKWARD:
                MoveFunction(new Vector3(0, 0, -1 * speed * Time.deltaTime));
                break;
            case CilynderState.RIGHT:
                MoveFunction(new Vector3(1 * speed * Time.deltaTime, 0, 0));
                break;
            case CilynderState.LEFT:
                MoveFunction(new Vector3(-1 * speed * Time.deltaTime, 0, 0));
                break;
            case CilynderState.UP:
               MoveFunction(new Vector3(0, 1 * speed * Time.deltaTime, 0));
                break;
            case CilynderState.DOWN:
                MoveFunction(new Vector3(0, -1 * speed * Time.deltaTime, 0));
                break;
            default:
                  MoveFunction(new Vector3(0, 0, 1 * speed * Time.deltaTime));
                break;

        }
    }


    IEnumerator ChangeDirectionCoroutine()
    {
        yield return new WaitForSeconds(5);

        cilynderRenderer.material.color = UnityEngine.Random.ColorHSV();
        int randomState = UnityEngine.Random.Range(0, 6);
        Debug.Log(randomState);
        if (randomState == 0) cilynderState = CilynderState.FORWARD;
        if (randomState == 1) cilynderState = CilynderState.BACKWARD;
        if (randomState == 2) cilynderState = CilynderState.RIGHT;
        if (randomState == 3) cilynderState = CilynderState.LEFT;
        if (randomState == 4) cilynderState = CilynderState.UP;
        if (randomState == 5) cilynderState = CilynderState.DOWN;

        StartCoroutine(ChangeDirectionCoroutine());
    }

   
}
