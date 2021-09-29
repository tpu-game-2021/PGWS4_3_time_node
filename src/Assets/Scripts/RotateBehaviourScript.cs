using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{
    void Update()
    {
        float rorate = 360.0f * Time.deltaTime / 10.0f;

        this.transform.Rotate(0, rorate, 0);
    }
}
