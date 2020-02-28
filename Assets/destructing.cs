using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructing : MonoBehaviour {
    public GameObject obj;
    public float health;
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void takeDamage(float amount)
    {
        health -= amount;
        if(health<= 0f)
        {
            die();
        }

    }
    private void die()
    {
        Destroy(obj);
    }
}
