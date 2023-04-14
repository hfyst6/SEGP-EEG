using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject OneLapTrigg;
    public GameObject HalfLapTrigg;
    public Text ScoreText;
    private int bonusedScore;

    void OnTriggerEnter(){
        bonusedScore = (int)(int.Parse(ScoreText.GetComponent<Text>().text)*1.5f);
        ScoreText.GetComponent<Text>().text = ""+bonusedScore;
        OneLapTrigg.SetActive(true);
        HalfLapTrigg.SetActive(false);
    }
}
