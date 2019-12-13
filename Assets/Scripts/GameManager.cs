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
            modelroot.SetActive(false);
            ScanUI.Instance.SetActive(true);
        }
        else if (_type == 1)//游戏
        {
            modelroot.SetActive(true);
            ScanUI.Instance.SetActive(false);
        }
    }


    public void ResetGame()
    {
        BlackUI.Instance.ResetUI();

    }


    public void ExitGame()
    {
        Debug.LogError("退出app");
        Application.Quit();
    }
}