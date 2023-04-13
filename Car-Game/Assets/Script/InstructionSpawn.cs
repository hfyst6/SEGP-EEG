using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionSpawn : MonoBehaviour
{
    public GameObject message;
    // Update is called once per frame
    void Update()
    {
        if(BrainWaves.value < 0.5f){
            message.SetActive(true);
        }else{
            message.SetActive(false);
        }
    }
}
