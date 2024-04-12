using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Canvas : MonoBehaviour
{
    [SerializeField] List<Button> buttons;
    [SerializeField] List<GameObject> panels;
    [SerializeField] List<Button> backButtons;
    [SerializeField] SpawnerData spawnerData;
    [SerializeField] Music music;

    public enum ExerciseState { FREE, SHOOT_GUN, SNIPER }
    public ExerciseState exerciseState;


    private void StartFunction()
    {
        DefaultButtonColor();
        buttons[0].image.color = Color.red;

        if (exerciseState == ExerciseState.FREE)
        {
            SceneManager.LoadScene(1);
            spawnerData.time = PlayerPrefs.GetInt("GameTime");
            spawnerData.velocitySpawner = PlayerPrefs.GetInt("RatioEnemies");
        }
        if (exerciseState == ExerciseState.SHOOT_GUN)
        {
            SceneManager.LoadScene(2);
        }
        if (exerciseState == ExerciseState.SNIPER)
        {
            SceneManager.LoadScene(3);
        }
    }


    private void ClearPanelsFunction()
    {
        for (int i = 0; i < panels.Count; i++)
        {
            panels[i].SetActive(false);
        }

    }

    private void DifficultyFunction()
    {
        DefaultButtonColor();
        buttons[1].image.color = Color.red;
        ClearPanelsFunction();
        panels[1].SetActive(true);
    }
    private void MusicFunction()
    {
        DefaultButtonColor();
        buttons[2].image.color = Color.red;
        ClearPanelsFunction();
        panels[2].SetActive(true);
    }
    private void ExerciseFunction()
    {
        DefaultButtonColor();
        buttons[3].image.color = Color.red;
        ClearPanelsFunction();
        panels[3].SetActive(true);
    }
    private void OptionsFunction()
    {
        DefaultButtonColor();
        buttons[4].image.color = Color.red;
        ClearPanelsFunction(); //nuevo
        panels[4].SetActive(true);//nuevo
    }
    private void BackFunction()
    {

        ClearPanelsFunction();
        panels[0].SetActive(true);
    }

    private void EasyFunction()
    {
        DefaultButtonColor();
        buttons[5].image.color = Color.red;
        if (exerciseState == ExerciseState.FREE)
        {
            PlayerPrefs.SetInt("GameTime", 1);
            PlayerPrefs.SetInt("RatioEnemies", 3);

        }

    }
    private void NormalFunction()
    {
        DefaultButtonColor();
        buttons[6].image.color = Color.red;
        if (exerciseState == ExerciseState.FREE)
        {
            PlayerPrefs.SetInt("GameTime", 5);
            PlayerPrefs.SetInt("RatioEnemies", 3);

        }
    }
    private void HardFunction()
    {
        DefaultButtonColor();
        buttons[7].image.color = Color.red;
        if (exerciseState == ExerciseState.FREE)
        {

            PlayerPrefs.SetInt("GameTime", 7);
            PlayerPrefs.SetInt("RatioEnemies", 2);

        }
    }
    private void VeryHardFunction()
    {
        DefaultButtonColor();
        buttons[8].image.color = Color.red;
        if (exerciseState == ExerciseState.FREE)
        {
            PlayerPrefs.SetInt("GameTime", 9);
            PlayerPrefs.SetInt("RatioEnemies", 1);

        }
    }

    private void Music1Function()
    {
        DefaultButtonColor();
        buttons[9].image.color = Color.red;
        music.PlayMusicFunctionClear(0);

    }
    private void Music2Function()
    {
        DefaultButtonColor();
        buttons[10].image.color = Color.red;
        music.PlayMusicFunctionClear(1);
    }

    private void Music3Function()
    {
        DefaultButtonColor();
        buttons[11].image.color = Color.red;
        music.PlayMusicFunctionClear(2);
    }

    private void Music4Function()
    {
        DefaultButtonColor();
        buttons[12].image.color = Color.red;
        music.PlayMusicFunctionClear(3);
    }
    private void FreeFunction()
    {
        DefaultButtonColor();
        buttons[13].image.color = Color.red;
        exerciseState = ExerciseState.FREE;
    }
    private void ShootGunFunction()
    {
        DefaultButtonColor();
        buttons[14].image.color = Color.red;
        exerciseState = ExerciseState.SHOOT_GUN;
    }
    private void SniperFunction()
    {
        DefaultButtonColor();
        buttons[15].image.color = Color.red;
        exerciseState = ExerciseState.SNIPER;
    }

    public void ExitFunction()
    {
        Application.Quit(); 
    }
  

    private void Awake()
    {
        buttons[0].onClick.AddListener(StartFunction);
        buttons[1].onClick.AddListener(DifficultyFunction);
        buttons[2].onClick.AddListener(MusicFunction);
        buttons[3].onClick.AddListener(ExerciseFunction);
        buttons[4].onClick.AddListener(OptionsFunction);
        buttons[5].onClick.AddListener(EasyFunction);
        buttons[6].onClick.AddListener(NormalFunction);
        buttons[7].onClick.AddListener(HardFunction);
        buttons[8].onClick.AddListener(VeryHardFunction);
        buttons[9].onClick.AddListener(Music1Function);
        buttons[10].onClick.AddListener(Music2Function);
        buttons[11].onClick.AddListener(Music3Function);
        buttons[12].onClick.AddListener(Music4Function);
        buttons[13].onClick.AddListener(FreeFunction);
        buttons[14].onClick.AddListener(ShootGunFunction);
        buttons[15].onClick.AddListener(SniperFunction);

        backButtons[0].onClick.AddListener(BackFunction);
        backButtons[1].onClick.AddListener(BackFunction);
        backButtons[2].onClick.AddListener(BackFunction);
        backButtons[3].onClick.AddListener(BackFunction);
    }




    //START FUNCIONS ************************************************** 

    private void PanelsControllerFunction(int index)
    {
        for (int i = 0; i < panels.Count; i++)
        {
            panels[i].SetActive(false);
        }
        panels[index].SetActive(true);
    }



    private void Start()
    {
        PanelsControllerFunction(0);
        exerciseState = ExerciseState.FREE;
        EasyFunction();

    }





    //UPDATE FUNCTIONS **********************************************************

    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("GameTime"));
    }


    private void DefaultButtonColor()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].image.color = Color.yellow;
        }
    }



    /*
     "MaxNumberEnemies" : Numero maximo de enemigos en modo free ; 
     "RatioEnemies"    : Tiempo que pasa entre spawn de enemigos 
     "Music"           : Guarda la musica actual 
     
     
     
     */


}
