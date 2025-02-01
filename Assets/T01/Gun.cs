using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject obj;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject cloneObj = Instantiate(obj,pos);
            Rigidbody rb = cloneObj.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 50f);
        }
    }
}
