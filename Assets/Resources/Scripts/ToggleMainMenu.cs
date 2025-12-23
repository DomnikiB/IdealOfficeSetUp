using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToggleMainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu;
    [SerializeField]
    UnityEvent pauseGame;
    [SerializeField]
    UnityEvent lockCursor;
    //setInactive all other menus
    [SerializeField]
    UnityEvent otherEvents;

    public PauseManager pauseManager;
    
    
    public void OnToggleMainMenu()
    {
        //only if game is not already paused by another menu 
        if ((!pauseManager.isPaused && !mainMenu.activeSelf) || (pauseManager.isPaused && mainMenu.activeSelf))
        {
            pauseGame?.Invoke();
            lockCursor?.Invoke();
        }
        mainMenu.SetActive(!mainMenu.activeSelf);
        otherEvents?.Invoke();
    }
}
