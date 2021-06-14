using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Player"){
            Destroy(this.gameObject);
            GameObject.Find("Dead").GetComponent<StairNumber>().UpdateScore(-1);
        }
        
    }
}
