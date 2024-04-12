using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Canvas2 : MonoBehaviour
{
    [SerializeField] GameObject canvas2;
    [SerializeField] TMP_Text failsText;
    [SerializeField] TMP_Text shootText;
    [SerializeField] TMP_Text percentText;
    [SerializeField] TMP_Text timerText;
    public int fails;
    public  int shoot;
    public bool start;
    public float percent;
    int timerHours;
    public int timerMinutes;
    public int timerSeconds;


    private void Start()
    {
        StartCoroutine(CounterCoroutine());
    }
  
    public void TimerFunction()
    {
        
            timerText.text = timerHours.ToString() + " : " +
            timerMinutes.ToString() + " : " +
            timerSeconds.ToString();

            failsText.text=fails.ToString();
            shootText.text=shoot.ToString();    
             
           if(shoot>=1 || fails>=1 && shoot>=1) percent= (shoot * 100) / (fails  + shoot);
            percentText.text= percent.ToString();

      //  Debug.Log(timerHours + " : " + timerMinutes + " : " + timerSeconds);
                     
    }


    private void ActivateControllerFunction()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            canvas2.SetActive(true);
        }
        else
        {
            canvas2.gameObject.SetActive(false);
        }
    }





    private void Update()
    {
        ActivateControllerFunction();
        if (canvas2.activeInHierarchy) TimerFunction();
    }



    IEnumerator CounterCoroutine()
    {
        yield return new WaitForSeconds(1);
        
        if(timerSeconds < 59)
        {
            timerSeconds += 1;
        }
        else
        {
            timerSeconds = 0;
            
            if (timerMinutes < 59)
            {
                timerMinutes += 1;
            }
            else
            {
                timerMinutes = 0;
                timerHours += 1;
            }
            
        }
      
        StartCoroutine(CounterCoroutine());
      
       
    }
 
}



