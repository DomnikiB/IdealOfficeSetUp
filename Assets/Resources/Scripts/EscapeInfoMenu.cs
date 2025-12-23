using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EscapeInfoMenu : MonoBehaviour
{
    [SerializeField]
    GameObject infoMenu;
    [SerializeField]
    UnityEvent pauseGame;
    [SerializeField]
    UnityEvent lockCursor;
    [SerializeField]
    UnityEvent otherEvents;

    public PauseManager pauseManager;


    public void onEscapeInfoMenu()
    {
        pauseGame?.Invoke();
        lockCursor?.Invoke();
        infoMenu.SetActive(false);
        otherEvents?.Invoke();
    }
}
