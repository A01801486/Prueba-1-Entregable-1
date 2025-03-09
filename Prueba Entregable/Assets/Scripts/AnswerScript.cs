using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;

    public QuizManager quizManager;

    public void Respuesta()
    {
        if (isCorrect)
        {
            Debug.Log("Respuesta Correcta");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Respuesta Incorrecta");
            quizManager.correct();
        }
    }
}
