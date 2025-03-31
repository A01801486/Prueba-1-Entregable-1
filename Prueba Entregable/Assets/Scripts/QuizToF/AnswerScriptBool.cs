using UnityEngine;

public class AnswerScriptBool : MonoBehaviour
{
    public bool isCorrect = false;

    public QuizManagerBool quizManagerbool;

    public void Respuesta()
    {
        if (isCorrect)
        {
            Debug.Log("Respuesta Correcta");
            quizManagerbool.correct();
        }
        else
        {
            Debug.Log("Respuesta Incorrecta");
            quizManagerbool.incorrect();
        }
    }
}

