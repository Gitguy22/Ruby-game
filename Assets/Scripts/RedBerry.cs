using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBerry : MonoBehaviour
{
public GameObject blueBerry;

 void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Destroy(blueBerry);
    }
}
