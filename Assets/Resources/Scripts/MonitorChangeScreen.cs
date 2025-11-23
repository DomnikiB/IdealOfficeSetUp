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

        Material[] materials = meshRenderer.materials;
	Material[] newMaterials = new Material[2];
	
        isChange = !isChange;
        newMaterials[0] = materials[0];
        newMaterials[1] = isChange ? newMaterial : oldMaterial;

        meshRenderer.materials = newMaterials;
    }
}
