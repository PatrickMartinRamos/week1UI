using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timeScript : MonoBehaviour
{
    public TMP_Text file1Time;

    void Start()
    {
        myTime = Time.realtimeSinceStartup;
        file1Time.SetText(myTime.ToString("00:00:00"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
