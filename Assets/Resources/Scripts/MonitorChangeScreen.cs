using UnityEngine;

public class MonitorChangeScreen : MonoBehaviour
{
    public Material newMaterial, oldMaterial;
    public bool isChange = false;

    public void changeMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
        {
            Debug.LogError("No MeshRenderer found!");
            return;
        }

        Material[] mats = meshRenderer.materials;
	
        isChange = !isChange;
        
        mats[1] = isChange ? newMaterial : oldMaterial;

        meshRenderer.materials = mats;
    }
}
