using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class push_right : MonoBehaviour
{
    public float speed;
    public Text scoreText;


    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {

        this.GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        
        int integerText = Int16.Parse(scoreText.text);

        int newValue = integerText + 300;

        scoreText.text = newValue.ToString();

    }
}
