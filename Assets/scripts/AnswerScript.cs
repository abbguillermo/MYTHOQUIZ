using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
	public QuizManager quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
            Camera.main.fieldOfView = 50;
          

        }
        else
        {
            Debug.Log("Wrong Answer");
            Camera.main.fieldOfView = 50;
            quizManager.wrong();
            Handheld.Vibrate();
        }
    }

    
}
