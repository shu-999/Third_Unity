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

    public int quizNum;
    public int quizMaxNum = 4;
    public int count = 0;
    public bool flag;

    void Start()
    {
        questions = Question.text.Split(',') ;
        answers = Answer.text.Split(',') ;
        StartCoroutine(Flow());
    }

    IEnumerator Flow()
    {
        yield return new WaitForSeconds(1.5f);
        textQuestion.text = "��������͂��āu������v���������I";
        yield return new WaitForSeconds(1.5f);

        if (quizNum < quizMaxNum && quizNum < questions.Length)
        {
            textQuestion.text = questions[quizNum];
        }
        yield return null; 
    }

    public void QuizAnswer()
    {
        if (flag) return;

        if (answerField.text.Trim() == answers[quizNum].Trim())
        {
            textAnswer.text = "�����I";
            answerField.text = "";
            quizNum++;
            count++;
        }
        else
        {
            textAnswer.text = "�s�����I";
            answerField.text = "";
            quizNum++;
        }
        if (quizNum >= quizMaxNum || quizNum >= questions.Length)
        {
            textAnswer.text = "";
            textQuestion.text = "���ʂ�" + count.ToString() + "/" + quizMaxNum.ToString();
            flag = true;
        }
        else
        {
            textQuestion.text = questions[quizNum];
        }
    }
}
