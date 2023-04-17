using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public void LoadScene(string gameScene){
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameScene);
    }
}
