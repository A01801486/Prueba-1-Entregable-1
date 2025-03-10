using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<PreguntaRespuesta> QnA;
    
    public GameObject[] options;

    public int currentQuestion;

    public Text questionText;
    public TimerManager timer; // Llmando al timer
    public ScoreManager score; //llamado al score
    public int NumeroDePreguntas;
    

    private void Start()
    {
        GeneraPregunta();
        timer = GetComponent<TimerManager>();
        score = GetComponent<ScoreManager>();
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
        GeneraPregunta();
    }

    public void incorrect()
    {
        timer.ReiniciarTimer();
        QnA.RemoveAt(currentQuestion);
        GeneraPregunta();
    }

    void EstableceRespuestas()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Respuestas[i];
        
            if(QnA[currentQuestion].RespuestaCorrecta == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void GeneraPregunta()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        questionText.text = QnA[currentQuestion].Pregunta;

        EstableceRespuestas();
    }

    internal void TiempoAgotado()
    {
        QnA.RemoveAt(currentQuestion);
        GeneraPregunta();
    }
}