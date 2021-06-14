using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float downSpeed;
    
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        if(PlayeControl.isDead == true){
            transform.Translate(0, 0 , 0);
        }
        if(PlayeControl.isDead == false){
            transform.Translate(0, -downSpeed * Time.deltaTime, 0);
        }
        
    }
}
