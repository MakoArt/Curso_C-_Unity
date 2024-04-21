using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] List<Material> materials;

    void Start()
    {
        //StartCoroutine(ChangeSkyBox());
        RenderSettings.skybox = materials[Random.Range(0, materials.Count)];
    }


    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", speed * Time.time);
    }

    IEnumerator ChangeSkyBox()
    {
        yield return new WaitForSeconds(10f);
        RenderSettings.skybox = materials[Random.Range(0, materials.Count)];
       // StartCoroutine(ChangeSkyBox());
    }
}
