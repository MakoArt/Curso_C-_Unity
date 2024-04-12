using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public List<AudioSource> musicSources;
    [SerializeField] Slider slider;
    int indexMusic;
    int randomMusic;

    void Start()
    {
        randomMusic = UnityEngine.Random.Range(0, musicSources.Count);
        musicSources[randomMusic].Play();
    }

    public void ChangeVolumeFunction()
    {
        musicSources[indexMusic].volume = slider.value;
        musicSources[randomMusic].volume = slider.value;
    }

    private void PlayMusicFunction(int index)
    {
        musicSources[index].Play();
        indexMusic = index;
    }


    public void PlayMusicFunctionClear(int index)
    {
        for (int i = 0; i < musicSources.Count; i++)
        {
            musicSources[i].Stop();
        }

        PlayMusicFunction(index);
    }


}
