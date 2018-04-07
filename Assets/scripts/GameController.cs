using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public triggera trigger;
    public triggerb triggerb;
    public Question[] questions;
    public static List<Question> unansweredQuestions;
    public static GameController _instance;


    public Question currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private Text trueAnswerText, falseAnswerText,trueAnswerText1,falseAnswerText1,trueAnswerText2, falseAnswerText2;


    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        if (_instance == null)
            _instance = this;
        SetCurrentQuestion();
    }

   public void SetCurrentQuestion()
    {
        int randomQuestionsIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = questions[randomQuestionsIndex];

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "Verdadeiro";
            falseAnswerText.text = "Falso";
            trueAnswerText1.text = "Verdadeiro";
            falseAnswerText1.text = "Falso";
            trueAnswerText2.text = "Verdadeiro";
            falseAnswerText2.text = "Falso";
            triggerb.triggerbb = true;
            trigger.triggeraaw = true;

        }
        else
        {
            trueAnswerText.text = "Verdadeiro";
            falseAnswerText.text = "Falso";
            trueAnswerText1.text = "Verdadeiro";
            falseAnswerText1.text = "Falso";
            trueAnswerText2.text = "Verdadeiro";
            falseAnswerText2.text = "Falso";
            trigger.triggeraa = true;
            triggerb.triggerbbw = true;
        }

        factText.text = currentQuestion.fact;


    }
     public void TranstionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);
        SetCurrentQuestion();

    }
}