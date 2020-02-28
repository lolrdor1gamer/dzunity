using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pers : MonoBehaviour
{
    public GameObject achivment_gorshok;
    public GameObject achivment_bfg;
    public Transform gun;
    public Animator person;
    public GameObject firefromgun;
    public Transform _target;
    bool mouseright = false;
    bool mouseleft = false;
    public GameObject fire;
    int bfg = 0;
    public float moveSpeed = 0.1f; 
    public float verticalSpeed = 0.05f;
    public float vertSpeed = 2f;
    public float horSpeed = 2f;
    public Camera fpscam;
    public float damage = 10f;
    public float range = 30f;
    public float rangeuse = 3f;
    void Start()
    {
        person = GetComponent<Animator>();
        Cursor.visible = false;
    }

    void Update()
    {
        if (_target.position.y >= 14f && achivment_gorshok != null)
        {
            Debug.Log("1");
            achivment_gorshok.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F)) 
        person.SetInteger("idle", Random.Range(0, 10));
        else person.SetInteger("idle", 0);
        if (Input.GetMouseButtonDown(1)) 
        mouseright = !mouseright;
        float forwardMove = Input.GetAxis("Vertical") * moveSpeed;
        float sideMove = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalMove = Input.GetAxis("Jump") * verticalSpeed;
        float h = horSpeed * Input.GetAxis("Mouse X");
        _target.Rotate(0, h, 0);
        _target.position += _target.forward * forwardMove + _target.right * sideMove + _target.up * verticalMove;
        person.SetFloat("forward", forwardMove);
        person.SetBool("scope", mouseright);
        person.SetFloat("sideward", sideMove);
        if (Input.GetMouseButtonDown(0))
        mouseleft = true;
        else mouseleft = false;
        person.SetBool("fire", mouseleft);

        if (mouseleft == true)
        {
            if (bfg != 1)
            {
                achivment_bfg.SetActive(true);
                bfg = 1;
            }
            shoot();
            Instantiate(firefromgun, gun.position, gun.rotation);
            //firefromgun.transform.localScale -= new Vector3(0.9f,0.9f,0.9f);
        }
    }

    void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit , range))
        {
           Instantiate(fire, hit.point, hit.transform.rotation);
            Debug.Log(hit.transform.name);

            destructing destructing = hit.transform.GetComponent<destructing>();
            if(destructing!=null)
            {
                destructing.takeDamage(damage);
            }
        }
    }
}

