using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject dialogBox;
    private bool dialogTrigger;

    public GameObject redBerry;
    public GameObject blueBerry;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text= string.Empty;
        redBerry.gameObject.SetActive(false);
        blueBerry.gameObject.SetActive(false);
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X) && dialogTrigger)
        { 
            
            dialogBox.gameObject.SetActive(true);
            if (textComponent.text == lines[index])
            { 
               
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);

        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") )
        {
            dialogTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") )
        {
            dialogTrigger = false;
        }
    }
    
}
