using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance;
    public Camera MainCamera;

    private void Awake()
    {
        Instance = this;
    }


    public void SetActive_MainCamera(bool isActive)
    {
        MainCamera.gameObject.SetActive(isActive);
    }

}
