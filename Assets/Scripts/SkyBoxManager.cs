using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxManager : MonoBehaviour
{
    public static SkyBoxManager Instance;
    public Material SkyBox;
    private void Awake()
    {
        Instance = this;
    }

    public void ChangeSkybox(GameModelEnum gameModelEnum)
    {
        //if (gameModelEnum == GameModelEnum.SaoYiSao)
        //{
        //    RenderSettings.skybox = SkyBox0;
        //}
        //else if (gameModelEnum == GameModelEnum.Game)
        //{
        //    RenderSettings.skybox = SkyBox1;
        //}
    }
}
