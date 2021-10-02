using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneScript : MonoBehaviour
{
    public GameObject[] myObject;
    private int currentObject;
    public float timeLimit = 2f;
    bool change;

    private void Start()
    {
        currentObject = 0;
        change = true;
    }

    private void Update()
    {
        if (change)
        {
            ChangeObject();
            change = false;
        }
    }

    void ChangeObject()
    {
        myObject[currentObject].GetComponent<MeshRenderer>().material.SetFloat("Activate", 1f);
        StartCoroutine(RotateGlow());
    }

    IEnumerator RotateGlow()
    {
        float timer = 0;
        
        while (timer < timeLimit)
        {
            float rotate = 180f / timeLimit * Time.deltaTime;
            myObject[currentObject].transform.Rotate(0, 0, rotate);
            timer += Time.deltaTime;
            yield return null;
        }

        myObject[currentObject].GetComponent<MeshRenderer>().material.SetFloat("Activate", 0f);
        myObject[currentObject].transform.rotation = Quaternion.Euler(90f, 0, 0);

        currentObject++;
        currentObject %= myObject.Length;

        change = true;
    }
}
