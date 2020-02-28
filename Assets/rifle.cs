using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : MonoBehaviour
{
    public float vertSpeed = 2f;
    public float horSpeed = 2f;
    public Transform rifl;
    void Start()
    { }
    void Update()
    {
        float v = vertSpeed * -Input.GetAxis("Mouse Y");
        rifl.Rotate(v, 0, 0);
        if (rifl.rotation.x > 30)
        {
            rifl.Rotate(30, rifl.rotation.x, rifl.rotation.z);
        }
        else if (rifl.rotation.x < -30)
        {
            rifl.Rotate(-30, rifl.rotation.x, rifl.rotation.z);

        }
    }
}
