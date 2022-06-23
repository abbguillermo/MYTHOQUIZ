using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Panel;
    public GameObject Puntaje;
    public GameObject boton;

    public Text Questiontxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;
    public int proxima;


    public void Start()
    {
        totalQuestions = QnA.Count;
        Puntaje.SetActive(false);
        generateQuestion();
        proxima = SceneManager.GetActiveScene().buildIndex + 2;
    }

    public void GameOver()
    {
       
        Panel.SetActive(false);
        Puntaje.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
        if (score >= 10)
        {
            if (SceneManager.GetActiveScene().buildIndex<=6)
            {
                PlayerPrefs.SetInt("nivel", proxima);
                if (proxima > PlayerPrefs.GetInt("nivel"))
                {
                    PlayerPrefs.SetInt("nivel", proxima);
                    Debug.Log("ola");
                }
            }
            
        }
    }   

    public void retry()
    {
        SceneManager.LoadScene(0);
    }

    public void correct()
    {
        //contestas bn ;)
        score += 1;
        QnA.RemoveAt(currentQuestion);
        boton.SetActive(false);
        Invoke("botonON", 2.99f);
        Invoke("generateQuestion", 3f);
        
       
        
    }

    public void wrong()
    {
        //le pifias :(
        QnA.RemoveAt(currentQuestion);
        boton.SetActive(false);
        Invoke("botonON", 2.99f);
        Invoke("generateQuestion", 3f);
        
    }

    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }

    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            
            currentQuestion = Random.Range(0, QnA.Count);

            Questiontxt.text = QnA[currentQuestion].Question;
            SetAnswers();

           // QnA.RemoveAt(currentQuestion);
        }
        else
        {
            GameOver();
        }
    }
   void botonON ()
    {
        boton.SetActive(true);
    }
  
}
