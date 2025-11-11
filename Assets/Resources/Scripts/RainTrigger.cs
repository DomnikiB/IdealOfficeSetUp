using UnityEngine;
using UnityEngine.Events;

public class RainTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    void OnTriggerEnter(Collider other)
    {
    	onTriggerEnter.Invoke(); 
    }
    
    void OnTriggerExit(Collider other)
    {
    	onTriggerExit.Invoke(); 
    }
}
