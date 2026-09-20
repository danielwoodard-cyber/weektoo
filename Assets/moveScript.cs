using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class moveScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("hi chat");
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;
    }

 
    public float moveSpeed = 20f;

    public float rotateSpeed = 15f;
    private float verticalRotation = 0f;

    public Transform playerCamera;

    public void Update()



    {
        float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed;

        transform.Rotate(Vector3.up * mouseX);

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f);

        transform.localEulerAngles = new Vector3(verticalRotation, transform.localEulerAngles.y, 0f);
        playerCamera.localEulerAngles = new Vector3(verticalRotation, 0f, 0f);



        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            move += Vector3.down;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            move += Vector3.up;
        }

        if (Input.GetKey(KeyCode.None))
        {
            move = Vector3.zero;
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
