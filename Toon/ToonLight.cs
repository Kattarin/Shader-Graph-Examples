using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add script to lighting source
// Updates toon shadows for toon shader

public class ToonLight : MonoBehaviour
{
    private Light light = null;

    private void OnEnable()
    {
        light = this.GetComponent<Light>();
    }

    void Update()
    {
        Shader.SetGlobalVector("_ToonLightDirection", -this.transform.forward);
    }
}
