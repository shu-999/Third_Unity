using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
   public Transform tra;
    public int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(tra);
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
