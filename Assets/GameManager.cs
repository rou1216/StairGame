using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Button Restart;
    public GameObject player;
 void Start () {
        Restart.gameObject.SetActive(false);
 }
 
 void Update () {
        if (PlayeControl.isDead)
        {
            player.SetActive(false);
            Restart.gameObject.SetActive(true);
            
        }
 }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}

