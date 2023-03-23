using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    public GameObject rubyDialogBox;
    float timerDisplay;
    
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
    }
    
    //Method for displaying Rubys dialog
    public void RubyDisplayDialog()
    {
        timerDisplay = displayTime;
        rubyDialogBox.SetActive(true);
        StartCoroutine(DialogChain());
    }

    //method that waits after Jambis dialog to display Rubys
    IEnumerator DialogChain()
    {
        yield return new WaitForSeconds(4);
        RubyDisplayDialog();
    }
    
}