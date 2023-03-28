using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBerry : MonoBehaviour
{
public GameObject blueBerry;
Dialogue dialogue;

void Start()

{
    dialogue = FindObjectOfType<Dialogue>();
}

 void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Destroy(blueBerry);
        Destroy(dialogue.dialogBox);
    }
}
