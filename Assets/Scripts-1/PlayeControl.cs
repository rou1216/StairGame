using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeControl : MonoBehaviour
{   
    public static bool isDead;
    public float forceX;
    Rigidbody playerRigidbody;
    public float toLeft = -1;
    public float toRight = 1;
    public float stop = 0;
    float directionX;
    void Start()
    {
        isDead = false;
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            directionX = toLeft;
            
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            directionX = toRight;
            
        }
        else{
            directionX = 0;
            
        }
        Vector3 newDirection = new Vector3(directionX,0,0);
        playerRigidbody.AddForce(newDirection*forceX);
    }
}
