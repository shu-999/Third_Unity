using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine : MonoBehaviour
{
    public TextAsset Question;
    public TextAsset Answer;
    public string[] questions;
    public string[] answers;
    public Text textQuestion;
    public Text textAnswer;
    public InputField answerField;

    public bool flag;

    void Start()
    {
        questions = Question.text.Split(',') ;
        answers = Answer.text.Split(',') ;
        StartCoroutine(Flow());
    }

    IEnumerator Flow()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 100; i++)
        {
            textQuestion.text = "��������͂��āu������v���������I";
        }
        while (flag == false)
        {
            yield return new WaitForSeconds(3f);
            for (int i = 0; i < 100; i++)
            {
                textQuestion.text = questions[0];
                yield return new WaitForSeconds(3f);
            }
        }
    }

    void Update()
    {
        
    }

    public void QuizAnswer()
    {
        if (answerField.text == "��")
        {
            textAnswer.text = "�����I";
            flag = true;
            answerField.text = "";
        }
        else
        {
            textAnswer.text = "�s�����I";
            flag = true;
            answerField.text = "";
        }
    }
}
