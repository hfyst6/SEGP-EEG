using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject OneLapTrigg;
    public GameObject HalfLapTrigg;

    void OnTriggerEnter(){
        OneLapTrigg.SetActive(true);
        HalfLapTrigg.SetActive(false);
    }
}
