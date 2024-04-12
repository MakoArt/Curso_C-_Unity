using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    AudioSource[] sources;
    Button button;




    private void Awake()
    {
        if (AudioManager.instance == null)
        {
            AudioManager.instance = this;
            DontDestroyOnLoad(this);

            sources = FindObjectsOfType<AudioSource>();
            button = FindObjectOfType<Button>();

        }
        else
        {
            Destroy(gameObject);
        }



    }

    private void ChangeScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(1);
            //sources[0].Play();
            //sources[1].Pause();

        }
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(0);
            //sources[1].Play();
            //sources[0].Pause();

        }


    }



    private void Start()
    {


        sources[0].Play();
        button.onClick.AddListener(ChangeScene);
    }

}
