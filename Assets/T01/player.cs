using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0f, 0f, speed);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(speed, 0f, 0f);
        }

        transform.Rotate(0,Input.GetAxis("Mouse X"),0f);
    }
}
