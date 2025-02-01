using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform tra;
    public Rigidbody rb;
    public int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(tra);
        rb.AddForce(transform.forward * 5f + transform.up * 5f);
        if(hp < 0){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision col) {
        if(col.gameObject.name == "Bullet(Clone)"){
            hp -= 15;
        }
    }
}
