using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{


    // This function is called when the object is clicked
    public void ChangeTo(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

