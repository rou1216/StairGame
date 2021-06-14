using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Button GameOver;
    public GameObject player;
    

    void Start () {
        GameOver.gameObject.SetActive(false); 
    }
 
    void Update () {
        if (PlayeControl.isDead)
        {
            player.SetActive(false);
            GameOver.gameObject.SetActive(true);
            
        }
     }

   

}

