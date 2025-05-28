using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMap : MonoBehaviour
{
    public List<int> intList;
    public GameObject obj;
    public Transform playerPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.parent.name == "Player")
        {
            Instantiate(obj,transform.position,Quaternion.identity);
            intList.Add(1);
        }
    }
}
