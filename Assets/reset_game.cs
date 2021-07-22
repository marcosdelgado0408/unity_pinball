using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reset_game : MonoBehaviour
{

    static int count = 0;
    public Text scoreText;
    public Text tentativas;


    void Start()
    {
        
    }

    void Update()
    {   
        Vector3 posAtual = transform.position;


        if(posAtual.y < 0 && count < 1)
        {

            int integerText = Int16.Parse(tentativas.text);

            int newValue = integerText - 1;

            tentativas.text = newValue.ToString();

            scoreText.text = "0";


            transform.position = new Vector3(-4.5552f, 0.76f, -7.6f);
            count++;
                     

        }
        else if(posAtual.y < 0 && count >= 1)
        {
            tentativas.text = "0";
            scoreText.text = "0";
        }

        



    }
}
