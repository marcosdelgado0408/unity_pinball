using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodarAntiHor : MonoBehaviour
{
    float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(speed * Vector3.left);
        }

    }
}
