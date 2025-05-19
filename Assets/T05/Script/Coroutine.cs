using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine : MonoBehaviour
{
    public TextAsset Question;
    public string[] questions;
    public Text textQuestion;
    // Start is called before the first frame update
    void Start()
    {
        questions = Question.text.Split(',') ;
        StartCoroutine(Flow());
    }

    IEnumerator Flow()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < 100; i++)
        {
            textQuestion.text = "“š‚¦‚ð“ü—Í‚µ‚Äu“š‚¦‚év‚ð‰Ÿ‚»‚¤I";
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < 100; i++)
        {
            textQuestion.text = questions[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
