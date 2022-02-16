using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Vector3 whichWay = new Vector3(x, 0f, z);
        Vector3 whichWay = transform.right * x + transform.forward * z;

        controller.Move(whichWay * speed * Time.deltaTime);

    }
}
