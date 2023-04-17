using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlterScene : MonoBehaviour {


    public void ChangeTo(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }
}