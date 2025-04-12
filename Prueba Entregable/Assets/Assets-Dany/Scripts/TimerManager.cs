using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float tiempoLimite = 10f; // Tiempo que puede ser modificable
    private float tiempoRestante;
    private bool timerActivo = false;

    public Text timerText; 
    public QuizManager quizManager; 

    private void Start()
    {
        ReiniciarTimer();
    }

    private void Update()
    {
        if (timerActivo)
        {
            tiempoRestante -= Time.deltaTime;
            timerText.text = "Tiempo: " + Mathf.Ceil(tiempoRestante); // redondear

            if (tiempoRestante <= 0)
            {
                timerActivo = false;
                Debug.Log("Tiempo agotado. Pasando a la siguiente pregunta.");
                quizManager.TiempoAgotado(); 
                ReiniciarTimer();
            }
        }
    }

    public void ReiniciarTimer()
    {
        tiempoRestante = tiempoLimite;
        timerActivo = true;
    }

    public void DetenerTimer()
    {
        timerActivo = false;
    }
}
