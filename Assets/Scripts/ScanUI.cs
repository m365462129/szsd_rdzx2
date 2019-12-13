using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanUI : MonoBehaviour
{
    public static ScanUI Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }
}