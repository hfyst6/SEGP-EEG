using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSpeed : MonoBehaviour
{
    public Text SpeedText;
    public Rigidbody body;

    // Update is called once per frame
    void Update()
    {
        SpeedText.GetComponent<Text>().text = ((int)(body.GetComponent<Rigidbody>().velocity.magnitude*2.23693629f)).ToString();
    }
}
