using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalController : MonoBehaviour
{
    MeshRenderer[] crystalMeshes;
    Light[] light;
    public bool isGlowing = false;
    public float glowAmount = 1f;
    // Start is called before the first frame update
    void Start()
    {
        crystalMeshes = GetComponentsInChildren<MeshRenderer>();
        light = GetComponentsInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGlowing && glowAmount < 2f) 
        {
            glowAmount += 0.01f;
            foreach (MeshRenderer mesh in crystalMeshes)
            {
                ChangeGlowAmount(mesh.material);
            }
        }
        foreach (Light Light in light)
        {
            if (isGlowing && Light.intensity <= 2f)
            {
                Light.intensity += 0.01f;
            }
        }

    }

    private void ChangeGlowAmount(Material mat)
    {
        mat.SetFloat("_EmissionPower", glowAmount);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isGlowing = true;
            
        }
    }
}
