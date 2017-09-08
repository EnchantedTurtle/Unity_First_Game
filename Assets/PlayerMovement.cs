﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {


    public Rigidbody rb;

    public float forwardForce = 1750f;
    public float sidewaysForce = 1200f;
    public int scoreSpeed;
    public Text speedText;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float score = float.Parse(speedText.text.Split(':')[1]);
        float scoreadd = score * 1.000001f;
        forwardForce = forwardForce + scoreadd;

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
