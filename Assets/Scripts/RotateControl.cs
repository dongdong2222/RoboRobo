using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    public GameObject body;
    private bool selected = false;
    void Update()
    {
        if (!selected)
            return;

        if (transform.rotation.eulerAngles.x < 50)
            ;
        else if (transform.rotation.eulerAngles.x > -50)
            body.transform.position += new Vector3(0, 0, -0.01f);

    }


    public void Active()
    {
        selected = true;
    }
}
