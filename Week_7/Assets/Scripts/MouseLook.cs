using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public Transform playerBody;

    public float mouseSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        Debug.Log("Mouse X is " + mouseX);
        Debug.Log("Mouse Y is " + mouseY);

        if (Input.GetKey(KeyCode.Mouse1))
        {
            playerBody.Rotate(Vector3.up * mouseX);
            playerBody.Rotate(Vector3.left * mouseY);
        }

    }
}
