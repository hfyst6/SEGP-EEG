using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FinishRotate : MonoBehaviour
{
    public GameObject Car;
    public GameObject RotateCam;
    public GameObject Timer;
    public AudioSource Finished;
    public AudioSource FinishMusic;

    //public AudioSource lowAccelClip =  CarAudio.m_LowAccel ;
    //public AudioSource lowDecelClip = CarAudio.m_LowDecel;
    //public AudioSource highAccelClip = CarAudio.m_HighAccel;
    //public AudioSource highDecelClip = CarAudio.m_HighDecel;

    void OnTriggerEnter(){
        this.GetComponent<BoxCollider>().enabled = false;
        Destroy(CarAudio.m_LowAccel);
        Destroy(CarAudio.m_LowDecel);
        Destroy(CarAudio.m_HighAccel);
        Destroy(CarAudio.m_HighDecel);

        Timer.SetActive(false);
        Car.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        (Car.GetComponent("CarController") as MonoBehaviour).enabled = false;
        (Car.GetComponent("CarUserControl") as MonoBehaviour).enabled = false;
        Car.SetActive(true);
        RotateCam.SetActive(true);
        Finished.Play();
        FinishMusic.Play();
    }
}
