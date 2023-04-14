using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public GameObject MiniMap;
    public GameObject TimeLabel;
    public GameObject ScoreLabel;
    public GameObject SpeedLabel;

    public Text Score;
    public Text FinalScore;

    public Text Time;
    public Text FinalTime;

    public CoinsCollected coins;
    public Text FinalReward;

    void Update()
    {
        MiniMap.SetActive(false);
        TimeLabel.SetActive(false);
        FinalTime.text = Time.text;
        ScoreLabel.SetActive(false);
        FinalScore.text = Score.text;
        FinalReward.text = coins.getCoinsCollected().ToString(); 
        SpeedLabel.SetActive(false);
    }
}
