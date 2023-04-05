using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float FieldOfView = 50;
    public float DesiredView = 100;
    public float temp;
    private Camera camera;
    public Power pw;
    
    // Start is called before the first frame update
    void Start()
    {
        camera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pw.boosting){
            camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, DesiredView , temp * Time.deltaTime);
        }else{
            camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, FieldOfView , temp * Time.deltaTime);
        }
    }
}
