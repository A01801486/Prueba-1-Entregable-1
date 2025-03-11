using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Signup : MonoBehaviour
{
    private UIDocument join;
    private Button botonB;
    private Button botonR;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        join = GetComponent<UIDocument>();
        var root = join.rootVisualElement;

        botonB = root.Q<Button>("Back");
        botonR = root.Q<Button>("Register");
        botonR.RegisterCallback<ClickEvent, String>(Jugar,"Login");
        botonB.RegisterCallback<ClickEvent, String>(Jugar,"Inicio");
    }

    private void Jugar(ClickEvent evt, String nombreEscena)
    {
        SceneManager.LoadSceneAsync(nombreEscena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

