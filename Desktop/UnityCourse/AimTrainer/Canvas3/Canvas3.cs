using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;//

public class Canvas3 : MonoBehaviour
{
    [SerializeField] Button backButton;
    Statics statics;
    Canvas2 canvas2;
    [SerializeField] Client client;
    [SerializeField] TMP_Text hits;
    [SerializeField] TMP_Text errors;
    [SerializeField] TMP_Text percent;
    [SerializeField] TMP_Text record;



    private void BackToMenu()
    {
        statics.isDestroy = true;
        canvas2.fails = 0;
        canvas2.shoot = 0; 
        canvas2.timerMinutes = 0;
        canvas2.timerSeconds = 0;   
        canvas2.percent = 0;    
        SceneManager.LoadScene(0);
    }


    private void Awake()
    {
        backButton.onClick.AddListener(BackToMenu);
        statics=GameObject.FindGameObjectWithTag("Statics").GetComponent<Statics>();
        canvas2 = GameObject.FindGameObjectWithTag("Canvas2").GetComponent<Canvas2>();
       
    }

    private void PrintDataFunction()
    {
        hits.text = " HITS : " + canvas2.shoot.ToString();
        errors.text=" ERRORS : " + canvas2.fails.ToString();  
        percent.text=" % IN THIS GAME : " +  canvas2.percent.ToString() + "%";
        record.text= " % RECORD : " +  client.GetRecord().ToString() + "%";
    }

    private void Start()
    {   
        PrintDataFunction();
        Cursor.lockState = CursorLockMode.None;
    }
}
