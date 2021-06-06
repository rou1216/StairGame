using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair : MonoBehaviour
{
    public List<GameObject> Ground;
    public float PosotionY = 0;
    [Range(0,6)] public float spacingY;

    void Start()
    {
        
        for(int i = 0; i < 3; i++){
            SpawnGround();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnGround()
    {   
        
        GameObject newGround = Instantiate(Ground[0]);
        float StairX = (float) Random.Range(-3, 3);
        float StairY = PosotionY - spacingY;
        newGround.transform.position = new Vector3(StairX, StairY, 0);
            
        
    }
}
