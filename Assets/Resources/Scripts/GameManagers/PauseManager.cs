using UnityEngine;
using StarterAssets;

public class PauseManager : MonoBehaviour
{
    public bool isPaused = false;
    public FirstPersonController firstPersonController;
    
    public void pauseGame()
    {
    	isPaused = true;
        firstPersonController.canLook = false;
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        isPaused = false;
        firstPersonController.canLook = true;
        Time.timeScale = 1;
    }
    
    public void pauseResumeGame()
    {
        if (isPaused)
        {
            resumeGame();
        }
        else
        {
            pauseGame();
        }
    }
}
