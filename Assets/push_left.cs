using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_left : MonoBehaviour
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
        this.GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
    }
}
