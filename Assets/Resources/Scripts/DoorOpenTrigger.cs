using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour
{
    public GameObject animeObject, trigger;
    public AudioSource doorOpenSound;
    public bool action = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        action = false;
    }
    
    void Update()
    {
	if (action == true)
	{
		animeObject.GetComponent<Animator>().Play("DoorOpen");
		trigger.SetActive(false);
		doorOpenSound.Play();
		action = false;
	}
    }
}
