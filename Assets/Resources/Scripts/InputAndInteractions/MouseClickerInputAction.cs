using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MouseClickerInputAction : MonoBehaviour
{
    [Header("Define which layers should be taken into account for mouse clicking")]
    [SerializeField]
    LayerMask m_LayerMask;
    
    Camera m_Camera;

    [SerializeField]
    InputActionReference click;
    [SerializeField]
    InputActionReference point;
    [SerializeField]
    UnityEvent unityEvent;

    void Awake()
    {
        m_Camera = Camera.main;
    }


    private void OnEnable()
    {
        click.action.performed += PerformedResponse;
    }
    private void OnDisable()
    {
        click.action.performed -= PerformedResponse;
    }


    void PerformedResponse(InputAction.CallbackContext callbackContext)
    {
        Vector2 pointerPosition = point.action.ReadValue<Vector2>();
        Ray ray = m_Camera.ScreenPointToRay(pointerPosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, m_LayerMask))
        {
            Debug.Log("Raycast hit smth: " + hit.collider.gameObject.name);
            if (hit.collider.gameObject == this.gameObject)
            {
                Debug.Log("Raycast hit me");
                unityEvent?.Invoke();		
            }

        }
    }
 
}
