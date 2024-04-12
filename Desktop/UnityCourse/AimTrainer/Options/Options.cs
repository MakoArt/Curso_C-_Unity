using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Options : MonoBehaviour
{
    [SerializeField] Slider brighnessSlider;
    [SerializeField] Image imgBrighness;
    [SerializeField] Toggle toggle;
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] TMP_Dropdown dropdownQuality;
    public int quality;

     Resolution[] resoluciones;

    public void ChangeBrighness()
    {
        imgBrighness.color = new Color(0,0,0,brighnessSlider.value);
        PlayerPrefs.SetFloat("Brighness", brighnessSlider.value);
    }
    public void FullScreenFunction()
    {
        if(toggle.isOn) 
        { 
            Screen.fullScreen = true;
            PlayerPrefs.SetInt("FullScreen", 1);
            Debug.Log("Estamos en pantalla completa");
        }
        else
        {
            Screen.fullScreen = false;
            PlayerPrefs.SetInt("FullScreen", 0);
            Debug.Log("No Estamos en pantalla completa");
        }
    }

    public void OptionsResolution()
    {
        //Resolucion
        resoluciones = Screen.resolutions;
        dropdown.ClearOptions();
        List<string> dropDownResolutionString = new List<string>();
        int currentResolution = 0;
        
        for (int i = 0; i < resoluciones.Length; i++)
        {
            string resolutionString= resoluciones[i].width + " x " + resoluciones[i].height;
            dropDownResolutionString.Add(resolutionString);

            if (Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width && resoluciones[i].height == Screen.currentResolution.height)
            {
                 currentResolution=i;
            }

        }

       

        dropdown.AddOptions(dropDownResolutionString);
        dropdown.value = currentResolution; 
        dropdown.RefreshShownValue();

        dropdown.value = PlayerPrefs.GetInt("NumeroResolucion", 20);
    }

    public void ChangeResolution(int index)
    {

        PlayerPrefs.SetInt("NumeroResolucion", dropdown.value);
        Resolution resolucion= resoluciones[index]; 
        Screen.SetResolution(resolucion.width,resolucion.height,Screen.fullScreen);
    }
    public void ChangeQuality()
    {
        QualitySettings.SetQualityLevel(dropdownQuality.value);
        PlayerPrefs.SetInt("Quality", dropdownQuality.value); 
        quality = dropdownQuality.value;
    }

    void Start()
    {    
        //Brillo
        imgBrighness.color = new Color(0, 0, 0, PlayerPrefs.GetFloat("Brighness"));
        
        //Pantalla completa
        if(PlayerPrefs.GetInt("FullScreen")==0) Screen.fullScreen = false;
        if(PlayerPrefs.GetInt("FullScreen") == 1) Screen.fullScreen = true;

        //Resolutions
        OptionsResolution();

        Debug.Log(resoluciones.Length);

        //Quality  
        quality = PlayerPrefs.GetInt("Quality", 3); 
        dropdownQuality.value = quality;
        ChangeQuality();


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(" El valor es : " + dropdownQuality.value);
    }
}
