using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInteraciveSnow : MonoBehaviour
{
    void Update()
    {
        Shader.SetGlobalVector("_PlayerPos", transform.position);
    }
}
