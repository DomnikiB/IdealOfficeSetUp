using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MouseClickerInputActionHoverable : MonoBehaviour
{
    [Header("Define which layers should be taken into account for mouse clicking")]
    [SerializeField] 
    LayerMask m_LayerMask;

    Camera m_Camera;

    [SerializeField] 
    InputActionReference click;

    [SerializeField] 
    InputActionReference point;

    [Header("Define which events (on click or on hover) should take place")]
    [SerializeField] 
    UnityEvent onClicked;

    [SerializeField] 
    UnityEvent onHoverEnter;

    [SerializeField] 
    UnityEvent onHoverExit;
    
    [SerializeField] 
    GameObject mainMenu;
    
    public PauseManager pauseManager;

    bool isHovering = false;

    void Awake()
    {
        m_Camera = Camera.main;
    }

    void OnEnable()
    {
        click.action.performed += PerformedResponse;
        point.action.performed += PointerMoved;
    }

    void OnDisable()
    {
        click.action.performed -= PerformedResponse;
        point.action.performed -= PointerMoved;
    }

    void PointerMoved(InputAction.CallbackContext ctx)
    {
        Ray ray;
        
        if (Cursor.lockState == CursorLockMode.Locked)
	{
	    ray = m_Camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
	}
	else
	{
	    Vector2 pointerPosition = point.action.ReadValue<Vector2>();
	    ray = m_Camera.ScreenPointToRay(pointerPosition);
	}

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, m_LayerMask))
        {
            if (mainMenu.activeSelf == false && pauseManager.isPaused == false)
            {
		    if (!isHovering && hit.collider.gameObject == this.gameObject)
		    {
			isHovering = true;
			onHoverEnter?.Invoke();
		    }

		    if (isHovering && hit.collider.gameObject != this.gameObject)
		    {
			isHovering = false;
			onHoverExit?.Invoke();
		    }
            }
        }
        else
        {
            if (isHovering && mainMenu.activeSelf == false && pauseManager.isPaused == false)
            {
                isHovering = false;
                onHoverExit?.Invoke();
            }
        }
    }

    void PerformedResponse(InputAction.CallbackContext callbackContext)
    {
        if (!isHovering || mainMenu.activeSelf == true || pauseManager.isPaused == true) return;

        onClicked?.Invoke();
    }
}
