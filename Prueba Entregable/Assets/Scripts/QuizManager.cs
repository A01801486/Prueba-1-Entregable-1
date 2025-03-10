using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<PreguntaRespuesta> QnA;
    
    public GameObject[] options;

    public int currentQuestion;

    public Text questionText;
    public TimerManager timer;


    private void Start()
    {
        GeneraPregunta();
        timer = GetComponent<TimerManager>();
    }

    public void correct()
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