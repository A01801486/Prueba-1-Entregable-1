// Hace falta mejorar este sistema, es solo provisional
using UnityEngine;
using UnityEngine.UI;

public class FeedbackManager : MonoBehaviour
{
    public Text feedbackText; 
    public string[] mensajesCorrectos; // Mensajes para respuestas correctas
    public string[] mensajesIncorrectos; // Mensajes para respuestas incorrectas

    private int rachaCorrecta = 0;
    private int rachaIncorrecta = 0;

    public void RegistrarRespuesta(bool esCorrecto)
    {
        if (esCorrecto)
        {
            rachaCorrecta++;
            rachaIncorrecta = 0;
            MostrarFeedback(true);
        }
        else
        {
            rachaIncorrecta++;
            rachaCorrecta = 0;
            MostrarFeedback(false);
        }
    }

    private void MostrarFeedback(bool esCorrecto)  //Cambiar esta cosa
    {
        string mensaje;

        if (esCorrecto)
        {
            if (rachaCorrecta >= 3)
                mensaje = mensajesCorrectos[2]; 
            else if (rachaCorrecta == 2)
                mensaje = mensajesCorrectos[1]; 
            else
                mensaje = mensajesCorrectos[0]; 
        }
        else
        {
            if (rachaIncorrecta >= 3)
                mensaje = mensajesIncorrectos[2]; 
            else if (rachaIncorrecta == 2)
                mensaje = mensajesIncorrectos[1]; 
            else
                mensaje = mensajesIncorrectos[0]; 
        }

        feedbackText.text = mensaje;
        feedbackText.gameObject.SetActive(true);
        Invoke("OcultarFeedback", 2f);
    }

    private void OcultarFeedback()
    {
        feedbackText.gameObject.SetActive(false);
    }
}
