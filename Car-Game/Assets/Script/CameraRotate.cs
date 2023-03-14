using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public GameObject CarCamera;
    public GameObject RotateCamera;
    public GameObject Timer;

    public Transform AudioListener;

    // Update is called once per frame
    void Update()
    {
        //AudioListener.parent = RotateCamera.transform;
        transform.Rotate(0,0.85f,0,Space.World);

        if(Timer.activeSelf == true){
            RotateCamera.SetActive(false);
            CarCamera.SetActive(true);
            //AudioListener.parent = CarCamera.transform;
        }
    }
}
