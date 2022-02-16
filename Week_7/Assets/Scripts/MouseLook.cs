using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public Transform playerBody;

    public float mouseSpeed = 300f;

    private float  xRotation = 0f;

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.Mouse1))
         {
            float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

            //  Debug.Log("Mouse X is " + mouseX);
            //  Debug.Log("Mouse Y is " + mouseY);

            // Look LEFT/RIGHT
            //
            playerBody.Rotate(Vector3.up * mouseX);

            // Look UP/DOWN
            //
            // playerBody.Rotate(Vector3.left * mouseY);
            xRotation += mouseY;
            xRotation = Mathf.Clamp(xRotation, -45f, 45f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

         }

    }
}
