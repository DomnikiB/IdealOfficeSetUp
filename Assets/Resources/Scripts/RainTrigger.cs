using System;
using UnityEngine;
using UnityEngine.Events;

public class RainTrigger : MonoBehaviour
{
    [SerializeField] string tagFilter; //checks player's tag 
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    
    void OnTriggerEnter(Collider other)
    {
    	if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
    	onTriggerEnter.Invoke(); 
    }
    
    void OnTriggerExit(Collider other)
    {
    	if (!String.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;
    	onTriggerExit.Invoke(); 
    }
}
