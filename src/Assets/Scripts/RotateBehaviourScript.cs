using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{
    void Update()
    {
        //             360‚Å1üA1•b‚Å1‘‚¦‚é@1ü‚Ì•b”
        float rotate = 360.0f * Time.deltaTime / 10.0f;

        this.transform.Rotate(0, rotate, 0);
    }
}
