//Aun esta en progreso no agregar hasta terminar

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreManagerBool : MonoBehaviour
{
    public int preguntasCorrectas = 0; // numero de preguntas correctas
    public Text scoreText; 
    public QuizManagerBool NumeroDePrguntas;
    public void Start()
    {   
        NumeroDePrguntas = GetComponent<QuizManagerBool>();
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
