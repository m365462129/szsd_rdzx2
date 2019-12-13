using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject modelroot;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        GameManager.Instance.Switch(0);
    }

    int CurType = -10;
    public void Switch(int _type)
    {
        if (CurType == _type) return;
        CurType = _type;

        if (_type == 0)//扫一扫
        {
            ResetGame();
        }
        else if (_type == 1)//游戏
        {
            modelroot.SetActive(true);
        }
    }


    public void ResetGame()
    {
        BlackUI.Instance.ResetUI();
        modelroot.SetActive(false);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}