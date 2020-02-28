using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achivment : MonoBehaviour {
    public GameObject achivment1;
    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.X) && achivment1 != null)
            Destroy(achivment1);
	}
}
