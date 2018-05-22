using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public triggera triggera;                                                           //firts trigger on the pad a
    public triggera2 triggera2;                                                         //second trigger on the pad a
    public respostadava triggera3;                                                      //third trigger on the pad a
    public triggera3 triggera4;                                                         // forth trigger on the pad a
    public triggerb triggerb;                                                           //firts trigger on the pad b
    public triggerb2 triggerb2;                                                         //second trigger on the pad b
    public respostadavb triggerb3;                                                      //third trigger on the pad b
    public triggerab3 triggerb4;                                                        // forth trigger on the pad b
    public Question[] questions;                                                        // question list
    public static List<Question> unansweredQuestions;                                   // unansweredquestion list
    public static GameController _instance;                                             // instance of this Script
    public int checkpoint = 0;                                                          //checkpoint var
    public Question currentQuestion;                                                    // current question text
    [SerializeField]
    private Text factText;                                                              // text from the factText

    [SerializeField]
    private Text trueAnswerText, falseAnswerText,trueAnswerText1,falseAnswerText1,trueAnswerText2, falseAnswerText2, trueAnswerText3, falseAnswerText3; // text from the true or anwser 


    void Start()
    {   
        
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)  // if the list of questions has nathing in it then get all the gestions from the Question list
        {
            unansweredQuestions = questions.ToList<Question>();
            Debug.Log(unansweredQuestions);
        }
        if (_instance == null)
            _instance = this;
        SetCurrentQuestion(); // when the list is done  call the function setcurrentquestion
    }

   public void SetCurrentQuestion()
    {
        int randomQuestionsIndex = Random.Range(0, unansweredQuestions.Count); //randomize the question 
        currentQuestion = questions[randomQuestionsIndex];
        if (currentQuestion.isTrue) //if the currentquestion bolean is true then do this
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
            triggera.triggeraa = false;
            triggera2.triggeraa2 = false;
            triggera3.triggeraa = false;
            triggera4.triggeraa3 = false;
            triggerb.triggerbbw = false;
            triggerb2.triggerbbw2 = false;
            triggerb3.triggerbbwy = false;
            triggerb4.triggerbbw = false;


        }
        else //else do that 
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
            triggerb.triggerbb = false;
            triggerb2.triggerbb2 = false;
            triggerb3.triggerbby = false;
            triggerb4.triggerbb = false;
            triggera.triggeraaw = false;
            triggera2.triggeraaw2 = false;
            triggera3.triggeraaw = false;
            triggera4.triggeraaw3 = false;
        }

        factText.text = currentQuestion.fact; //set the current question text to the question text


    }
     public void TranstionToNextQuestion() // transition to next question
    {
        unansweredQuestions.Remove(currentQuestion); // remove the current question from the list 
        SetCurrentQuestion(); //and set another question 

    }
}