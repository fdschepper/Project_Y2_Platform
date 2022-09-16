using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score",5);
        PlayerPrefs.SetFloat("time",10.50f);
        PlayerPrefs.SetFloat("iets anders", PlayerPrefs.GetFloat("iets anders") + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") && SceneManager.GetActiveScene().buildIndex !=5)
        {
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
    	//This will load the next scene in the build settings (edit with ctrl + shift + b)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("lvl1");
    }
}
