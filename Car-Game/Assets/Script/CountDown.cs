using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject SpeedLabel;
    public GameObject CountDownText;
    public AudioSource GetReady;

    public GameObject Timer;
    public GameObject Carcontrols;

    public ParticleSystem nitruseffect1;
    public ParticleSystem nitruseffect2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (CountStart ());
    }

    IEnumerator CountStart(){
        nitruseffect1.Stop();
        nitruseffect2.Stop();
        yield return new WaitForSeconds (0.5f);
        CountDownText.GetComponent<Text> ().text = "3";
        GetReady.Play();
        CountDownText.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDownText.SetActive(false);
        CountDownText.GetComponent<Text> ().text = "2";
        CountDownText.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDownText.SetActive(false);
        CountDownText.GetComponent<Text> ().text = "1";
        CountDownText.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDownText.SetActive(false);
        CountDownText.GetComponent<Text> ().text = "GO !";
        CountDownText.SetActive(true);
        Timer.SetActive(true);
        Carcontrols.SetActive(true);
        SpeedLabel.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDownText.SetActive(false);
    }
}
