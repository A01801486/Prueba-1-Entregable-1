using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Regresar : MonoBehaviour
{
    private UIDocument menu;
    private Button botonR;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonR = root.Q<Button>("BotonR");
        botonR.RegisterCallback<ClickEvent, String>(Jugar,"MENU");
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
