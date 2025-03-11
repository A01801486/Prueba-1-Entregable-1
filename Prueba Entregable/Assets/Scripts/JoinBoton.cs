using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class JoinBoton : MonoBehaviour
{
    private UIDocument join;
    private Button botonJ;
    private Button botonE;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        join = GetComponent<UIDocument>();
        var root = join.rootVisualElement;

        botonJ = root.Q<Button>("BotonJoin");
        botonE = root.Q<Button>("Exit");
        botonJ.RegisterCallback<ClickEvent, String>(Jugar,"MenuJ");
        botonE.RegisterCallback<ClickEvent, String>(Jugar,"Inicio");
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
