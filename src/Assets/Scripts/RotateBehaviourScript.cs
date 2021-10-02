using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{
    void Update()
    {
        float rotate = 360f * Time.deltaTime / 10;

        this.transform.Rotate(0, rotate, 0);
    }
}
