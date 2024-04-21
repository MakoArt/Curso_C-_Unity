using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class DiaNoche : MonoBehaviour
{
   
    [SerializeField] TMP_Text timerText;
    [SerializeField] GameObject lightObject;
    [SerializeField] List<GameObject> lightObjects; 

    public int timerHours;
    public int timerMinutes;
    public int timerSeconds;

   
    


    private void Start()
    {
        StartCoroutine(CounterCoroutine());
        timerHours = 12; 
        timerMinutes = 0;
        timerSeconds = 0;
}

    public void TimerFunction()
    {

        timerText.text = timerHours.ToString() + " : " +
        timerMinutes.ToString() + " : " +
        timerSeconds.ToString();
     
    }

    private void LightRotation()
    {
        lightObject.transform.localRotation *= Quaternion.Euler( 0.00416f, 0, 0);
    }

    private void NightLighting()
    {
        if (timerHours > 17)
        {
            for (int i = 0; i < lightObjects.Count; i++)
            {
                lightObjects[i].SetActive(true);
            }
        }
        else if(timerHours > 6 && timerHours <= 17) 
        {
            for (int i = 0; i < lightObjects.Count; i++)
            {
                lightObjects[i].SetActive(false);
            }
        }
    }

     private void Update()
    {
      
         TimerFunction();
         NightLighting();
         
    }



    IEnumerator CounterCoroutine()
    {
        yield return new WaitForSeconds(0.001f);

        if (timerSeconds < 59)
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
            else if(timerMinutes >= 59)
            {
                timerMinutes = 0;
                timerHours += 1;
            }
           

        }

        if (timerHours >= 24)
        {
            timerHours = 0;
        }


        LightRotation();
        StartCoroutine(CounterCoroutine());
    }
}
