using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoinStack : MonoBehaviour
{
    public GameObject coinStack;
    // Update is called once per frame
    void Update()
    {
        if(BrainWaves.value > 0.5f){
            coinStack.SetActive(true);
        }else{
            coinStack.SetActive(false);
        }
    }
}
