using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionControl : MonoBehaviour
{
    public GameObject body;
    private bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (!selected)
            return;

        if (transform.rotation.eulerAngles.x < 50)
            body.transform.localPosition += new Vector3(0,0,0.01f);
        else if(transform.rotation.eulerAngles.x > -50)
            body.transform.localPosition += new Vector3(0,0,-0.01f);

    }


    public void Active()
    {
        selected = true;
    }
    public Vector3 Distance(Quaternion angle)
    {
        Vector3 vec = angle.eulerAngles;
        
        return vec;
    }
}
