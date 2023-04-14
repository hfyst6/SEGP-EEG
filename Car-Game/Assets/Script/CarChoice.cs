using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject OrangeBody;

    public int Carimport;
    // Start is called before the first frame update
    void Start()
    {
        Carimport = GlobalCar.CarType;
        if(Carimport == 1){
            RedBody.SetActive(true);
        }
        if(Carimport == 2){
            BlueBody.SetActive(true);
        }
        if(Carimport == 3){
            OrangeBody.SetActive(true);
        }
    }
}
