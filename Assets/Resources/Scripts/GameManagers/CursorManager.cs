using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public bool isLocked = true;
    
    void Start()
    {
    	Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isLocked = true;
    }
    
    public void unlockCursor()
    {
    	Cursor.lockState = CursorLockMode.None;
	Cursor.visible = true;
	isLocked = false;
	Debug.Log("cursor state" + Cursor.lockState);
    }
    
    public void lockCursor()
    {
    	Cursor.lockState = CursorLockMode.Locked;
	Cursor.visible = false;
	isLocked = true;
    }
    
    public void lockUnlockCursor()
    {
    	if (isLocked)
    	{
    		unlockCursor();
    	}
    	else
    	{
    		lockCursor();
    	}
    }
    
}
