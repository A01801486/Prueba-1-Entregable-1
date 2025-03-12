//Aun esta en progreso no agregar hasta terminar

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    public int preguntasCorrectas = 0; // numero de preguntas correctas
    public Text scoreText; 
    public QuizManager NumeroDePrguntas;
    public void Start()
    {   
        NumeroDePrguntas = GetComponent<QuizManager>();
    }

    void Update()
    {
        scoreText.text = preguntasCorrectas + "/" + NumeroDePrguntas.NumeroDePreguntas ;

    }

    public void AgregarPunto()
    {
        preguntasCorrectas++;
    }


}

