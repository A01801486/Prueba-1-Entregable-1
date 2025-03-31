using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class QuizManagerBool : MonoBehaviour
{
    public List<PreguntaRespuesta> QnA;
    
    public GameObject[] options;
    public int currentQuestion;

    public Text questionText;
    private TimerManagerBool timer; // Llmando al timer
    private ScoreManagerBool score; //llamado al score
    public int NumeroDePreguntas; // Saber numero de preguntas 
    private FeedbackManager feedbackManager;
    

    private void Start()
    {
        GeneraPregunta();
        timer = GetComponent<TimerManagerBool>();
        score = GetComponent<ScoreManagerBool>();
        feedbackManager = GetComponent<FeedbackManager>();
        NumeroDePreguntas = QnA.Count;
        //Debug.Log(NumeroDePreguntas);
        {
            
        }
    }

    public void correct()
    {
        timer.ReiniciarTimer();
        QnA.RemoveAt(currentQuestion);
        score.AgregarPunto();
        feedbackManager.RegistrarRespuesta(true);
        GeneraPregunta();
    }

    public void incorrect()
    {
        timer.ReiniciarTimer();
        QnA.RemoveAt(currentQuestion);
        feedbackManager.RegistrarRespuesta(false);
        GeneraPregunta();
    }

    void EstableceRespuestas()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScriptBool>().isCorrect = false;
            
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Respuestas[i];
        
            if(QnA[currentQuestion].RespuestaCorrecta == i+1)
            {
                options[i].GetComponent<AnswerScriptBool>().isCorrect = true;
            }
        }
    }
    void GeneraPregunta()
    {
        if (QnA.Count == 0)
        {
            SceneManager.LoadScene("EscenaFeedback"); // Cambiar a la escena de feedback
            Debug.Log(score.preguntasCorrectas); // Este es el valor del numero de respuestas correctas
        }
        else{ 
        
            currentQuestion = Random.Range(0, QnA.Count);

            questionText.text = QnA[currentQuestion].Pregunta;

            EstableceRespuestas();
        }
    }

    internal void TiempoAgotado()
    {   
        
        QnA.RemoveAt(currentQuestion);
        feedbackManager.RegistrarRespuesta(false);
        GeneraPregunta();
    }

    public void RegresarAlMenu()
    {
        SceneManager.LoadScene("MenuJ"); 
    }
    

}