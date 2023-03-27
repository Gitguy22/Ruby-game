using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    public GameObject rubyDialogBox;
    float timerDisplay;
    public TMP_Text conversationBox;

    public string[] conversation;
    
    void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;
        
    }
    
    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
                rubyDialogBox.SetActive(false);
            }
        }
    }
    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
        StartCoroutine(DialogChain());
    }
    
    //Method for displaying Rubys dialog
    public void RubyDisplayDialog()
    {
        timerDisplay = displayTime;
        rubyDialogBox.SetActive(true);
        
    }

    //method that waits after Jambis dialog to display Rubys
    IEnumerator DialogChain()
    {
        yield return new WaitForSeconds(4);
        RubyDisplayDialog();
    }

    public void Conversation()
    {
        
        dialogBox.SetActive(true);
        for (int i = 0; i < conversation.Length; i++)
        {
            timerDisplay = displayTime;
            if (timerDisplay >= 0)
            {
                timerDisplay -= Time.deltaTime;
                conversationBox.text = conversation[i];
                if (timerDisplay < 0)
                {
                    conversationBox.text = conversation[i];
                }
            }

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Conversation();
            Thread.Sleep(4000);
        }
    }
}