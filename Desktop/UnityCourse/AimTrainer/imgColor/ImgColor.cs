using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgColor : MonoBehaviour
{
    private void Start()
    {
        Image image = GetComponent<Image>();
        image.color = new Color(0, 0, 0, PlayerPrefs.GetFloat("Brighness"));
    }
    private void Update()
    {
        Image image = GetComponent<Image>();
        image.color = new Color(0, 0, 0, PlayerPrefs.GetFloat("Brighness"));
    }
}
