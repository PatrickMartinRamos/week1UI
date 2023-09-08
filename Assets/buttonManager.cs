using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{

    public Image bellImage;
    public Image barlImage;
    public float duration;
    public Vector3 targeRotation;
    public float fadeoutteDur;

    // Start is called before the first frame update
    void Start()
    {
        bellRotate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void bellRotate()
    {
        bellImage.transform.DOLocalRotate(targeRotation, duration).SetEase(Ease.InOutCirc).SetLoops(-1,LoopType.Yoyo);
    }

    public void Fade()
    {
        bellImage.DOFade(0, fadeoutteDur);
    }
    public void transition()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(barlImage.transform.DOLocalMoveX(-333, 4.5f));
        sequence.AppendInterval(2);

        sequence.Append(barlImage.transform.DOLocalRotate(targeRotation, duration));
        sequence.AppendInterval(4);

        sequence.Append(barlImage.DOFade(0, fadeoutteDur));
    }
}
