using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour
{
    public void Back() {
        SceneManager.LoadScene(0);
    }
    public void EasyTrack(){
        SceneManager.LoadScene(1);
    }
    public void MediumTrack(){
        SceneManager.LoadScene(2);
    }
    public void HardTrack(){
        SceneManager.LoadScene(3);
    }
}
