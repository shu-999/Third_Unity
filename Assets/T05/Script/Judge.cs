using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judge : MonoBehaviour
{
    public TextAsset Question;
    public string[] questions;
    public Text textQuestion;

    void Start()
    {
        questions = Question.text.Split(',');
    }

    void Update()
    {
        
    }
    public void Answer(string answer)
    {
        if (answer == questions[0])
        {
            textQuestion.text = "ê≥âÅI";
        }
        else
        {
            textQuestion.text = "ïsê≥âÅI";
        }
    }
}
