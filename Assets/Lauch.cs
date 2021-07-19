using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lauch : MonoBehaviour
{

    public float chargeRate;
    
    public float pushAmount;
    float amountStart = 0f;

    public float pushRadius;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(pushAmount < 40000)
            {
                pushAmount += chargeRate;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Empurrar();
        }


    }


    // tranform.position -> posicao atual do objeto

    void Empurrar()
    {
        // Computes and stores colliders touching or inside the sphere.
        Collider[] colliders = Physics.OverlapSphere(transform.position, pushRadius);

        foreach(Collider pushedObject in colliders)
        {
            if (pushedObject.CompareTag("sphere"))
            {
                Rigidbody pushedBody = pushedObject.GetComponent<Rigidbody>();
                pushedBody.AddExplosionForce(pushAmount, Vector3.up, pushRadius);
            }
            
        }

        pushAmount = amountStart;


    }


}



