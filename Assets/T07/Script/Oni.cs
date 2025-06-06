using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oni : MonoBehaviour
{
    public float speed = 5f;
    public float maxSpeed = 5f;
    public Transform target;
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

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Kabe")
        {
            Debug.Log("•Ç‚É‚Ô‚Â‚©‚Á‚½");
            transform.rotation = target.rotation;
        }
    }
}

