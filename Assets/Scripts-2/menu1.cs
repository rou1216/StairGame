using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene("Level3");

    }

    public void retry1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void retry2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void retry3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
}
