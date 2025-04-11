using UnityEngine;
using UnityEngine.SceneManagement;
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

    public void VolverAlMenu()
    {
        if (ScoreManager.instance != null)
        {
            Destroy(ScoreManager.instance.gameObject); // Destruye el objeto que quedó con DontDestroyOnLoad
            ScoreManager.instance = null; // Limpia la instancia para evitar referencias futuras
        }

        SceneManager.LoadScene("MenuJ"); // Cambia "MenuJ" por el nombre exacto de tu escena de menú si es diferente
    }
}
