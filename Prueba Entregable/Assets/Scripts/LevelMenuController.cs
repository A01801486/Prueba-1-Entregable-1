using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelMenuController : MonoBehaviour
{
    [Header("Datos de Niveles")]
    public LevelData[] levels;

    [Header("UI del menú izquierdo")]
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public Image previewImage;
    public Animator previewAnimator;

    [Header("Boton Jugar")]
    public Button playButton;
    
    [Header("Boton Animación")]
    public Button animationButton;

    private int currentLevelIndex = 0;

    // Método llamado por cada botón de nivel
    public void SelectLevel(int index)
    {
         Debug.Log("Seleccionado nivel: " + index);

        if (index < 0 || index >= levels.Length) return;

        currentLevelIndex = index;
        LevelData level = levels[index];

        // Actualizar UI
        titleText.text = level.levelName;
        descriptionText.text = level.description;
        previewImage.sprite = level.previewImage;

        // Cambiar animación si tienes distintas
        if (previewAnimator != null && level.animationController != null)
        {
            previewAnimator.runtimeAnimatorController = level.animationController;
        }

        // Actualizar el botón de jugar
        playButton.onClick.RemoveAllListeners();
        playButton.onClick.AddListener(() => LoadLevel(level.sceneName));

        // Actualizar el botón de animación
        animationButton.onClick.RemoveAllListeners();
        animationButton.onClick.AddListener(() => PlayAnimation());

    }

    void LoadLevel(string sceneName)
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            Debug.Log("Cargando escena: " + sceneName);
            SceneManager.LoadScene(sceneName);
        }
        else 
        {
            Debug.LogError("La escena no está en el Build Settings o el nombre está mal: " + sceneName);
        }
    }

    void PlayAnimation()
    {
        if (previewAnimator != null)
        {
            previewAnimator.Play("Scene01_CryptoFadeIn 1");  // <-- cambia esto por el nombre real del estado de animación
            Debug.Log("Reproduciendo animación del nivel");
        }
    }

}
