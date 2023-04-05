using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0.85f,0,Space.World);
    }
}
