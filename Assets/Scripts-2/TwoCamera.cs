using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoCamera : MonoBehaviour
{
 
    public float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayeControl.isDead == true){
            transform.Translate(0, 0 , 0);
        }

        if(PlayeControl.isDead == false){
            time += (float) Time.deltaTime;
            if(time < 30){
                transform.Translate(0,(float) -1.5 * Time.deltaTime, 0);
            }
            if(time > 30){
                transform.Translate(0,(float) -2 * Time.deltaTime  , 0);
            }
            if(time > 60){
                transform.Translate(0,(float) -2.5 * Time.deltaTime  , 0);
            }
            if(time > 80){
                transform.Translate(0, (float)-3 * Time.deltaTime , 0);
            }
        }
       
        
    }
}
