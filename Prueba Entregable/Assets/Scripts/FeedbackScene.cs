using UnityEngine;
using UnityEngine.UI;

public class FeedbackScene : MonoBehaviour
{
    public Text calificacionText;

    void Start()
    {
        GetCalificacion(); // Llamamos al método para obtener la calificación al iniciar
    }

    public void GetCalificacion()
    {
        int nota = 0;

        // Verificar si ScoreManager.instance existe y obtener la calificación
        if (ScoreManager.instance != null)
        {
            nota = ScoreManager.instance.preguntasCorrectas;
        }

        // Asignar la calificación al texto
        if (nota > 0)
        {
            calificacionText.text = nota.ToString() + "/10";
        }
        else
        {
            calificacionText.text = "0/10";
        }
    }
}
