using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;
    bool checker;
    private void Start()
    {
        checker = PlayerPrefs.HasKey("volume");
        Debug.Log(checker);
        checker= PlayerPrefs.HasKey("inputName");
        Debug.Log(checker);
        checker = PlayerPrefs.HasKey("resolution");
        Debug.Log(checker);
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
        nameInput.text = PlayerPrefs.GetString("inputName");
        resolution.value = PlayerPrefs.GetInt("resolution");


    }

    public void SetVolumen()
    {
        // Guardar los datos del volumen.
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        Debug.Log(volumeSlider.value);
    }

    public void SetName()
    {
        // Guardar los datos del nombre.
        PlayerPrefs.SetString("inputName", nameInput.text);
        Debug.Log(nameInput.text);
    }

    public void SetResolution()
    {
        // Guardar los datos de la resolucion.
        PlayerPrefs.SetInt("resolution", resolution.value);
        Debug.Log(resolution.value);
    }

    public void ResetDefault()
    {
        // Borrar todos los datos existentes.
        PlayerPrefs.DeleteAll();
        volumeSlider.value = 0;
        nameInput.text = "";
        resolution.value = 0;
    }
}
