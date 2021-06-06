using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairManger : MonoBehaviour
{
    public List<GameObject> Ground;
    public float PosotionY = 0;
    [Range(0,6)] public float spacingY;
        

    void Start()
    {
        SpawnGround();
        TrapGround();
        
    }

    
    void Update()
    {
        //InvokeRepeating("SpawnGround", 1, 1); 
        
    }
    void SpawnGround()
    {   
        for(int i = 0; i < 100; i++){
            GameObject newGround = Instantiate(Ground[0]);
            float StairX = (float) Random.Range(-2.1f, 2.1f);
            float StairY = PosotionY - spacingY * i;
            float StairZ = (float) -0.8;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
        }   
        
    }
    void TrapGround()
    {
        for(int i = 0; i < 40; i++){
            GameObject newGround = Instantiate(Ground[1]);
            float StairX = (float) Random.Range(-2.1f, 2.1f);
            float StairY = -10 - 7 * i;
            float StairZ = (float) -0.8;
            newGround.transform.position = new Vector3(StairX, StairY, StairZ);
        }   
    }

}
