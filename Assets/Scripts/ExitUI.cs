using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitUI : MonoBehaviour
{
    public static ExitUI Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void OnClick()
    {
        GameManager.Instance.ExitGame();
    }
}
