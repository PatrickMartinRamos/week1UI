using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIScript : MonoBehaviour
{
    public GameObject alarmUIMenu;
    public Vector3 uiSize;
    public float closeTime;
    public float uiSpeed;
    public Vector3 targetPos;
    public Vector3 closePos;
    public bool isUIShowing=false;
    public void ResizeUI()
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
            alarmUIMenu.transform.DOScale(Vector3.one, closeTime);
        }
        alarmUIMenu.transform.DOLocalMove(closePos, uiSpeed);
    }
}
