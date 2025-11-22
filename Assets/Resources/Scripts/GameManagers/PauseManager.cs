using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public bool isPaused = false;
    
    public void pauseResumeGame()
    {
    	isPaused = !isPaused;
	Time.timeScale = isPaused ? 0 : 1;
	pauseMenu.SetActive(isPaused);
    }
    
}
