using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUp : MonoBehaviour
{
    public Text timeText_Oni;
    public Text timeText_Player;

    public float timeUp = 30f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeUp)
        {
            timeText_Oni.text = "LOSE";
            timeText_Player.text = "WIN";
        }
        else
        {
            timeText_Oni.text = "Time: " + Time.time.ToString("0.00");
            timeText_Player.text = "Time: " + Time.time.ToString("0.00");
        }
    }
}
