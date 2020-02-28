using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {
    public float vertSpeed = 2f;
    public float horSpeed = 2f;
    public Transform camer;
    void Start () 
    {}
	void Update ()
    {
        //        h = 0;
        //        v = 0;
        
        float v = vertSpeed * -Input.GetAxis("Mouse Y");
        camer.Rotate(v, 0 , 0);
        float h = horSpeed * Input.GetAxis("Mouse X");
        Debug.Log(h);
        Debug.Log(v);
        if (camer.rotation.x > 30)
        {
            camer.Rotate(30, camer.rotation.x, camer.rotation.z);
        }
        else if (camer.rotation.x < -30)
        {
            camer.Rotate(-30, camer.rotation.x, camer.rotation.z);

        }
        }
}
