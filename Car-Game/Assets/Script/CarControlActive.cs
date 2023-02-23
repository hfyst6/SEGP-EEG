using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject Carcontrol;

    // Start is called before the first frame update
    void Start()
    {
        (Carcontrol.GetComponent("CarController") as MonoBehaviour).enabled = true;  
    }
}
