//Aun esta en progreso no agregar hasta terminar

using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int preguntasCorrectas = 0;
    public Text scoreText; 

    private void Start()
    {
        ActualizarPuntaje();
    }

    public void AgregarPunto()
    {
        preguntasCorrectas++;
        ActualizarPuntaje();
    }

    private void ActualizarPuntaje()
    {
        scoreText.text = "Puntos: " + preguntasCorrectas;
    }
}

