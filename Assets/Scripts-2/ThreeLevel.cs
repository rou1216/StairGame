using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeLevel : MonoBehaviour
{
    public List<GameObject> Ground;
    public float PosotionY = 0;
    [Range(2,8)] public float spacingY ;
    [Range(3,10)] public float TrapY;
        

    void Start()
    {
        SpawnGround();
        TrapGround();
        Bomb();
    }
    
    void Update()
    {
        
        
    }
    void SpawnGround()
    {   
        
        float StairZ = (float) -0.8;

        for(int i = 0; i < 100; i++){
            GameObject newGround = Instantiate(Ground[0]);
            float StairX = (float) Random.Range(-2.1f, 2.1f);
            spacingY = (float) Random.Range(4.0f, 5.3f);
            float StairY = PosotionY - spacingY * i;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
            
        }   
         
    }
    void TrapGround()
    {
        for(int i = 0; i < 60; i++){
            GameObject newGround = Instantiate(Ground[1]);
            float StairX = (float) Random.Range(-2.1f, 2.1f);
            TrapY = (float) Random.Range(7.0f, 9.0f);
            float StairY = (float) -18 - TrapY * i;
            float StairZ = (float) -0.8;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
            
        }   
         
    }

    void Bomb(){
        for(int i = 0; i < 60; i++){
            GameObject newGround = Instantiate(Ground[2]);
            float StairX = (float) Random.Range(-2.1f, 2.1f);
            TrapY = (float) Random.Range(3.0f, 5.0f);
            float StairY = (float) -25 - TrapY * i;
            float StairZ = (float) -0.8;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
            
        }  
    }
}
