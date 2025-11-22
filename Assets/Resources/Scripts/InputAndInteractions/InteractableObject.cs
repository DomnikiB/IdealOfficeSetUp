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
    GameObject mainMenu;

 
    public void Target()
    {
    	if (mainMenu.activeSelf == false)
    	{
    		targetEvent?.Invoke();
    	}
    }

    public void UnTarget()
    {
    	if (mainMenu.activeSelf == false)
    	{
    		unTargetEvent?.Invoke();
    	}
    }

    public void Interact()
    {
	if (mainMenu.activeSelf == false)
    	{
    		// Simple interaction logic, e.g., pick up the item or trigger an event
		Debug.Log("Interacted with " + gameObject.name);

		// Do smth here or add it to the exposed UnityEvent on Unity Editor
		interactionEvent?.Invoke(); 
    	}
        
    }

}

