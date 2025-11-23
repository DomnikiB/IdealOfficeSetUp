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
    
    
    public void OnToggleMainMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        pauseGame?.Invoke();
        lockCursor?.Invoke();
        otherEvents?.Invoke();
    }
}
