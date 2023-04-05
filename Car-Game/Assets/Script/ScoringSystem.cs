using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int Score;
    public GameObject ScoreText;
    
    public CoinsCollected coins;
    public int CoinsCollected;

    void OnTriggerEnter(Collider other) {

        CoinsCollected = coins.getCoinsCollected();
        CoinsCollected++;
        coins.setCoinsCollected(CoinsCollected);

        //collectedSound.play();
        Score =  int.Parse(ScoreText.GetComponent<Text>().text);
        Score+=10;
        ScoreText.GetComponent<Text>().text = "" + Score;
        Destroy(gameObject);
    }
}