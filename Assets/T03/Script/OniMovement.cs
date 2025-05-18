using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OniMovement : MonoBehaviour
{
    public Text text_Oni;
    public Text text_Player;

    public float timeUp = 30f;

    private bool isGameFinished = false; // ’Ç‰Á
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 100);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 100);
        }
        if (Time.time >= timeUp)
        {
            text_Oni.text = "LOSE";
            text_Player.text = "WIN";
        }
        else
        {
            text_Oni.text = "Time: " + Time.time.ToString("0.00");
            text_Player.text = "Time: " + Time.time.ToString("0.00");
        }
        if (isGameFinished)
        {
            text_Oni.text = "WIN";
            text_Player.text = "LOSE";
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            isGameFinished = true;
        }
    }
}

