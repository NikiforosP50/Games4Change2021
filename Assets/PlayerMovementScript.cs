using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Vector3 upSpeed;
    public Vector3 downSpeed;
    public Vector3 leftSpeed;
    public Vector3 rightSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += downSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightSpeed;
        }
    }
}
