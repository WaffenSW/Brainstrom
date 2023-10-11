using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalMenuScript : MonoBehaviour
{
    [SerializeField] private Animator starAnimation;

    private void Start()
    {
        starAnimation.SetBool("Star",true);
    }
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