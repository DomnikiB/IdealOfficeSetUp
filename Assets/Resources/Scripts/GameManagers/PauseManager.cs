using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public bool isPaused = false;
    
    public void pauseResumeGame()
    {
    	isPaused = !isPaused;
	Time.timeScale = isPaused ? 0 : 1;
    }
    
}
