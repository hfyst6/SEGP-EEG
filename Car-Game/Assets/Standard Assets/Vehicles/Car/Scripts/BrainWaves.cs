using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainWaves : MonoBehaviour
{
    public static float value = 1;
    // Update is called once per frame
    void Start()
    {
        value = Random.Range(0.1f,1f);
        InvokeRepeating("RandomValue",3f, 4f);
    }

    void RandomValue() {
        value = Random.Range(0.1f,1f);
        Debug.Log($"{value}");
    }
}
