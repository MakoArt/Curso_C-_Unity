using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float xRot = 0;
    [SerializeField] float mouseSensibility = 100;
    [SerializeField] Transform player;


    void Start()
    {

    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X"); /** mouseSensibility * Time.deltaTime;*/
        // float mouseY = Input.GetAxis("Mouse Y"); /** mouseSensibility * Time.deltaTime;*/
        // xRot -= mouseY;
        // xRot = Mathf.Clamp(xRot, -10, 50);
        //transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        player.Rotate(Vector3.up * mouseX);

    }

}