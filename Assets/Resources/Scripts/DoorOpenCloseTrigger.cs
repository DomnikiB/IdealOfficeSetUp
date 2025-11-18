using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour
{
    [SerializeField] private Animator door = null;  	
    [SerializeField] private string doorOpen = "DoorOpen";
    [SerializeField] private string doorClose = "DoorClose";
    
    public AudioSource openSound, closeSound;
    
    private void OnTriggerEnter(Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
    		door.Play(doorOpen, 0, 0.0f);
    		openSound.Play();
    	}
    }
    
    private void OnTriggerExit(Collider other)
    {
    	if (other.CompareTag("Player"))
    	{
		door.Play(doorClose, 0, 0.0f);
		closeSound.Play();
    	}
    }
}
