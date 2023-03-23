using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixController : MonoBehaviour
{
    public GameObject simulation;
    public GameObject invertedCamera;
    public GameObject redBerry;
    
    public GameObject listener;

 void OnTriggerEnter2D(Collider2D other)
    {
        simulation.SetActive(true);
        invertedCamera.SetActive(true);
        listener.SetActive(false);

        Destroy(gameObject);
        Destroy(redBerry);
    }
}