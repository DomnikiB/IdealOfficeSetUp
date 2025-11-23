using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{    
    public void QuitApp() 
    {
    	Application.Quit();
    }
    
    public void ReloadApp()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	Time.timeScale = 1;
    }
    
}
