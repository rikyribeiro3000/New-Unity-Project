using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public triggera triggera;
    public triggera2 triggera2;
    public triggera3 triggera4;
    public respostadava triggera3;
    public triggerb triggerb; 
    public triggerb2 triggerb2;
    public respostadavb triggerb3;
    public triggerab3 triggerb4;
    public Question[] questions;
    public static List<Question> unansweredQuestions;
    public static GameController _instance;


    public Question currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private Text trueAnswerText, falseAnswerText,trueAnswerText1,falseAnswerText1,trueAnswerText2, falseAnswerText2, trueAnswerText3, falseAnswerText3;


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
            trueAnswerText3.text = "Verdadeiro";
            falseAnswerText3.text = "Falso";
            triggerb.triggerbb = true;
            triggerb2.triggerbb2 = true;
            triggerb3.triggerbby = true;
            triggerb4.triggerbb = true;
            triggera.triggeraaw = true;
            triggera2.triggeraaw2 = true;
            triggera3.triggeraaw = true;
            triggera4.triggeraaw3 = true;


        }
        else
        {
            trueAnswerText.text = "Verdadeiro";
            falseAnswerText.text = "Falso";
            trueAnswerText1.text = "Verdadeiro";
            falseAnswerText1.text = "Falso";
            trueAnswerText2.text = "Verdadeiro";
            falseAnswerText2.text = "Falso";
            trueAnswerText3.text = "Verdadeiro";
            falseAnswerText3.text = "Falso";
            triggera.triggeraa = true;
            triggera2.triggeraa2 = true;
            triggera3.triggeraa = true;
            triggera4.triggeraa3 = true;
            triggerb.triggerbbw = true;
            triggerb2.triggerbbw2 = true;
            triggerb3.triggerbbwy = true;
            triggerb4.triggerbbw = true;
            
        }

        factText.text = currentQuestion.fact;


    }
     public void TranstionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);
        SetCurrentQuestion();

    }
}