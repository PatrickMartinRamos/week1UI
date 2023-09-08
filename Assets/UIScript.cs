using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject alarmUIMenu;
    public Image bellImage;
    public Vector3 uiSize;
    public float closeTime;
    public float uiSpeed;
    public Vector3 targetPos;
    public Vector3 closePos;
    public bool isUIShowing=false;

    public float fadeinteDur;

    public void ResizeUI()//resize AlarmUI
    {
        if (isUIShowing)
        {
            alarmUIMenu.transform.DOScale(uiSize, closeTime).SetEase(Ease.InOutElastic);
        }
        if(!isUIShowing)
        {
            isUIShowing = false;
            alarmUIMenu.transform.DOScale(Vector3.zero, closeTime).SetEase(Ease.InOutElastic);
        }
    }

    public void showUI()
    {
        isUIShowing = true;
        alarmUIMenu.transform.DOLocalMove(targetPos, uiSpeed).OnComplete(()=> ResizeUI());
    }

    public void closeUI()
    {
        isUIShowing = false;
        if (!isUIShowing)
        {
            bellImage.DOFade(100, fadeinteDur);
        }
        alarmUIMenu.transform.DOLocalMove(closePos, uiSpeed);
    }
    
}
