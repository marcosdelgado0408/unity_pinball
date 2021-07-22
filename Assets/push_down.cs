using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// 200 points
public class push_down : MonoBehaviour
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

        this.GetComponent<Rigidbody>().AddForce(Vector3.down * speed);
        
        
        int integerText = Int16.Parse(scoreText.text);

        int newValue = integerText + 200;

        scoreText.text = newValue.ToString();

    }



}
