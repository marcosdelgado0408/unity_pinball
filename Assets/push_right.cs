using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_right : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {

        this.GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
    }
}
