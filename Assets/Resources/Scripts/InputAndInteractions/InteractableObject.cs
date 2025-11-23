using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
 
    [SerializeField]
    UnityEvent interactionEvent;
    [SerializeField]
    UnityEvent targetEvent;
    [SerializeField]
    UnityEvent unTargetEvent;
    [SerializeField]
    GameObject menuToBeDisabled;
    
    public PauseManager pauseManager;

 
    public void Target()
    {
    	if (menuToBeDisabled.activeSelf == false && pauseManager.isPaused == false)
    	{
    		targetEvent?.Invoke();
    	}
    }

    public void UnTarget()
    {
    	if (menuToBeDisabled.activeSelf == false && pauseManager.isPaused == false)
    	{
    		unTargetEvent?.Invoke();
    	}
    }

    public void Interact()
    {
	if (menuToBeDisabled.activeSelf == false && pauseManager.isPaused == false)
    	{
    		// Simple interaction logic, e.g., pick up the item or trigger an event
		Debug.Log("Interacted with " + gameObject.name);

		// Do smth here or add it to the exposed UnityEvent on Unity Editor
		interactionEvent?.Invoke(); 
    	}
        
    }

}

