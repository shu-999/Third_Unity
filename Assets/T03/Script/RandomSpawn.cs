using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject oni;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        oni.transform.position = new Vector3(Random.Range(-4.5f,54.5f),10f,Random.Range(25.5f,54.5f));
        player.transform.position = new Vector3(Random.Range(-4.5f,54.5f),10f,Random.Range(-4.5f,54.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
