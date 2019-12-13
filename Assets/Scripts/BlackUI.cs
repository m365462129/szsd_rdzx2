using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BlackUI : MonoBehaviour
{
    public static BlackUI Instance;
    public Image image;
    private void Awake()
    {
        Instance = this;
    }

    public void ResetUI()
    {
        image.gameObject.SetActive(false);
    }

    public void Hide()
    {
        Color color = image.color;
        color.a = 0;
        image.color = color;
    }

    public void StartBlack()
    {
        Hide();
        image.gameObject.SetActive(true);
        image.DOColor(new Color(0, 0, 0, 1), 1.5f);
    }
}
