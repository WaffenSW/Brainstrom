using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalMenuScript : MonoBehaviour
{
    
    public void NextLevel()
    {
        int Scene = SceneManager.GetActiveScene().buildIndex + 1;
        if(Scene != SceneManager.GetActiveScene().buildIndex)
        {
            SceneManager.LoadScene(Scene);
        }
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}