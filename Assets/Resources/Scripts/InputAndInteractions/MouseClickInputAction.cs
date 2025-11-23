using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MouseClickInputAction : MonoBehaviour
{
    [Header("Layers considered for raycast")]
    [SerializeField] 
    LayerMask m_LayerMask;

    [SerializeField] 
    InputActionReference click;

    [Header("Events")]
    [SerializeField] UnityEvent onClicked;
    [SerializeField] UnityEvent onHoverEnter;
    [SerializeField] UnityEvent onHoverExit;

    [SerializeField] GameObject menuToBeDisabled;
    
    public PauseManager pauseManager;
    
    public CursorManager cursorManager;

    Camera m_Camera;
    bool isHovering = false;

    void Awake()
    {
        m_Camera = Camera.main;
    }

    void OnEnable()
    {
        click.action.performed += OnClick;
    }

    void OnDisable()
    {
        click.action.performed -= OnClick;
    }

    void Update()
    {
        if (menuToBeDisabled.activeSelf || pauseManager.isPaused)
        {
            ResetHover();
            return;
        }

        Ray ray;

        // If cursor is locked → use center of screen
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            ray = m_Camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        }
        else
        {
            // Free cursor → use pointer position
            Vector2 pointer = Mouse.current.position.ReadValue();
            ray = m_Camera.ScreenPointToRay(pointer);
        }

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, m_LayerMask))
        {
            if (!isHovering && hit.collider.gameObject == gameObject)
            {
                isHovering = true;
                onHoverEnter?.Invoke();
            }
            else if (isHovering && hit.collider.gameObject != gameObject)
            {
                ResetHover();
            }
        }
        else
        {
            ResetHover();
        }
    }

    void ResetHover()
    {
        if (isHovering)
        {
            isHovering = false;
            onHoverExit?.Invoke();
        }
    }

    void OnClick(InputAction.CallbackContext ctx)
    {
        if (isHovering && !menuToBeDisabled.activeSelf && !pauseManager.isPaused)
        {
            cursorManager.unlockCursor();
            onClicked?.Invoke();
        }
    }
}
