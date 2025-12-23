using UnityEngine;
using StarterAssets;

public class UIManager : MonoBehaviour
{
    public FirstPersonController firstPersonController;
    public GameObject panel;

    public void OpenUI()
    {
        panel.SetActive(true);
        firstPersonController.canLook = false;
    }

    public void CloseUI()
    {
        panel.SetActive(false);
        firstPersonController.canLook = true;
    }
}
