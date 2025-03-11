using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimSelector : MonoBehaviour
{
    public void OpenAnim(int AnimationId)
    {
        string AnimationName = "Animation " + AnimationId;
        SceneManager.LoadScene(AnimationName);
    }
}