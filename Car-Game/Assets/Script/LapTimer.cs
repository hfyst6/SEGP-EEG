using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LapTimer : MonoBehaviour
{
    public Text currentTimeText;
    float currentTime;

    void Start() {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       currentTime = currentTime - Time.deltaTime;
       TimeSpan time = TimeSpan.FromSeconds(currentTime);
       currentTimeText.text = time.ToString(@"mm\:ss\:f");
    }
}
