using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLevel : MonoBehaviour
{
    public List<GameObject> Ground;
    public float PosotionY = 0;
    [Range(2,8)] public float spacingY ;
    [Range(3,10)] public float TrapY;
        

    void Start()
    {
        SpawnGround();
        TrapGround();
        
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
            float StairY = PosotionY - spacingY * i;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
            
        }   
         
    }
    void TrapGround()
    {
        for(int i = 0; i < 60; i++){
            GameObject newGround = Instantiate(Ground[1]);
            float StairX = (float) Random.Range(-2.1f, 2.1f);
            float StairY = (float) -22 - TrapY * i;
            float StairZ = (float) -0.8;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
            
        }   
         
    }
}
