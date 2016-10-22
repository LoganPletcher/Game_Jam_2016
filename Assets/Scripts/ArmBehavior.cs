﻿using UnityEngine;
using System.Collections;

public class ArmBehavior : MonoBehaviour {

    private float Radius = 3;
    public Vector3 Displacement;
    public Vector3 Displacement2;
    float speed = 20.0f;
    float zPositionLock;
    float xPositionLock;
    bool wkey = false;
    bool skey = false;
    bool qkey = false;
    bool ekey = false;
    bool dkey = false;
    bool akey = false;
    public GameObject PlayerBody;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Displacement = (gameObject.transform.position - PlayerBody.transform.position);
        wkey = false;
        skey = false;
        qkey = false;
        ekey = false;
        dkey = false;
        akey = false;

        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W) && transform.position.z < Radius + PlayerBody.transform.position.z)
        {
            wkey = true;
        }

        if (Input.GetKey(KeyCode.S) && transform.position.z > -Radius + PlayerBody.transform.position.z)
        {
            skey = true;
        }
        if (Input.GetKey(KeyCode.Q) && transform.position.y < Radius + PlayerBody.transform.position.y)
        {
            qkey = true;
        }
        if (Input.GetKey(KeyCode.E) && transform.position.y > -Radius + PlayerBody.transform.position.y)
        {
            ekey = true;
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x < Radius + PlayerBody.transform.position.x)
        {
            dkey = true;
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > -Radius + PlayerBody.transform.position.x)
        {
            akey = true;
        }
        if (wkey == true)
        {
            direction += new Vector3(0, 0, 1);
        }
        if (skey == true)
        {
            direction += new Vector3(0, 0, -1);
        }
        if (qkey == true)
        {
            direction += new Vector3(0, 1, 0);
        }
        if (ekey == true)
        {
            direction += new Vector3(0, -1, 0);
        }
        if (dkey == true)
        {
            direction += new Vector3(1, 0, 0);
        }
        if (akey == true)
        {
            direction += new Vector3(-1, 0, 0);
        }
        transform.position += direction * speed * Time.deltaTime;
        //if (Displacement.x >= Radius )
        //{
        //    gameObject.transform.position = new Vector3(PlayerBody.transform.position.x + Displacement.x, PlayerBody.transform.position.y, PlayerBody.transform.position.z);
        //}
        //if (Displacement.y >= Radius)
        //{
        //    gameObject.transform.position = new Vector3(PlayerBody.transform.position.x, PlayerBody.transform.position.y + Displacement.y, PlayerBody.transform.position.z);
        //}
        //if (Displacement.z >= Radius)
        //{
        //    gameObject.transform.position = new Vector3(PlayerBody.transform.position.x, PlayerBody.transform.position.y, PlayerBody.transform.position.z + Displacement.z);
        //}

    }
}
