using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInfoMenu : MonoBehaviour
{
 
    [SerializeField]
    GameObject infoMenu;
    
    public void OnToggleInfoMenu()
    {
        infoMenu.SetActive(!infoMenu.activeSelf);
    }
}

