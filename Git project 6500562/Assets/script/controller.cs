using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //print("hello");


        if (Input.GetKey(KeyCode.W))
        {
            //print("W");

            //transform.position = new Vector3(0, 2, 0);
            transform.position = new Vector3(0, transform.position.y + 0.03f, 0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            //print("W");

            //transform.position = new Vector3(0, -2, 0);
            transform.position = new Vector3(0, transform.position.y + -0.03f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //print("W");

            //transform.position = new Vector3(-2, 0, 0);
            transform.position = new Vector3(transform.position.x + -0.03f, 0, 0);
        }
        

        if (Input.GetKey(KeyCode.D))
        {
            //print("W");

            //transform.position = new Vector3(2, 0, 0);       
            transform.position = new Vector3(transform.position.x + 0.03f, 0, 0);
        }
    }
}
