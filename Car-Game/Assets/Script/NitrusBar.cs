using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NitrusBar : MonoBehaviour
{
    public Slider nitruslevel;
    public Power pw;

    // Update is called once per frame
    void Update()
    {
        nitruslevel.value = pw.nitrusValue/20;
    }
}
