using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100));
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -50));
            Debug.Log("D");

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(50, 0, 0));
            Debug.Log("W");

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-50, 0, 0));
            Debug.Log("S");

        }
    }
    
}
