using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_07 : MonoBehaviour
{
    public float speed = 5f;
    public float maxSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed <= maxSpeed)
        {
            speed += 0.001f;
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0f, -90f, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0f,90f,0);
        }
    }
}
