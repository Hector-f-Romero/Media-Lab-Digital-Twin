using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }
}
