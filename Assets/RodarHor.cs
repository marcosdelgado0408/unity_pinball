using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodarHor : MonoBehaviour
{
    float speed = 5f;
    public GameObject pivotObj; // referencia ao pivot

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update(){


        if (Input.GetKeyDown(KeyCode.RightArrow)){
            

            transform.RotateAround(pivotObj.transform.position, Vector3.down, -45);

        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)){
            transform.RotateAround(pivotObj.transform.position, Vector3.down, 45);
        }
        

    }
}
