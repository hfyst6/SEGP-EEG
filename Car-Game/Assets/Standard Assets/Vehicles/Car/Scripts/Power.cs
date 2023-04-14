using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public float boostForce;
    public float FOV;
    public Camera cam;
    public bool boosting = false;
    public float nitrusValue;
    public ParticleSystem nitruseffect1;
    public ParticleSystem nitruseffect2;

    // Update is called once per frame
    void Update()
    {
        if(!boosting && nitrusValue <= 10){
            if(BrainWaves.value > 0.4f){
                nitrusValue += (nitrusValue >= 10) ? (10 - nitrusValue) : Time.deltaTime/2;
            }
        }else{
            nitrusValue -= (nitrusValue <= 0) ? 0 : Time.deltaTime*1.5f;
        }

        if(nitrusValue <= 0){
            stopnitrus();
        }

        if((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.DownArrow))  && boosting){

            stopnitrus();

        } else if(Input.GetKeyDown(KeyCode.LeftShift)){

            if(nitrusValue >= 0){

                startnitrus();

            }
            
        } 

        
    }

    public void startnitrus(){
        if(boosting){
            return;
        }
        Rigidbody R = gameObject.GetComponent<Rigidbody>();
        R.AddForce(gameObject.transform.forward * boostForce);
        boosting = true;
        nitruseffect1.Play();
        nitruseffect2.Play();
    }

    public void stopnitrus(){
        if(!boosting){
            return;
        }
        boosting = false;
        nitruseffect1.Stop();
        nitruseffect2.Stop();
    }
}
