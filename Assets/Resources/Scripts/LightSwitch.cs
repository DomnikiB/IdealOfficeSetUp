using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
	public GameObject lightOn, lightOff, switchOn, switchOff;
	public bool toggle;
	public AudioSource switchSound;

	public void ToggleLightSwitch() 
	{
		if (toggle == true) 
		{
		    lightOn.SetActive(true);
		    lightOff.SetActive(false);
		    switchOn.SetActive(true);
		    switchOff.SetActive(false);
		    switchSound.Play();
		}
		else if (toggle == false)
		{
		    lightOn.SetActive(false);
		    lightOff.SetActive(true);
		    switchOn.SetActive(false);
		    switchOff.SetActive(true);
		    switchSound.Play();
		}
	}
	
}
