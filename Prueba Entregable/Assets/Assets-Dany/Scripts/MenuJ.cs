using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuJ : MonoBehaviour
{
    private UIDocument menu;
    private Button botonE;
    // private Button botonB;
    private Button botonS;
    private Button botonJ;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonS = root.Q<Button>("Settings");
        botonE = root.Q<Button>("Exit");
        botonJ = root.Q<Button>("Juega");

// poner las escenas correspondientes

        // pendiente escena settings
        botonS.RegisterCallback<ClickEvent, String>(Jugar,"Settings");
        // pendiente por hacer escena temas 
        botonJ.RegisterCallback<ClickEvent, String>(Jugar,"Level_Selector_Canva");
        botonE.RegisterCallback<ClickEvent, String>(Jugar,"Inicio11");
    }

    private void Jugar(ClickEvent evt, String nombreEscena)
    {
        SceneManager.LoadSceneAsync(nombreEscena);
    }

    /* private void JugarB(ClickEvent evt)
    {
        print("Jugar B");
        SceneManager.LoadSceneAsync("EscenaMapa");
    } */

    // Update is called once per frame
    void Update()
    {
        
    }
}
