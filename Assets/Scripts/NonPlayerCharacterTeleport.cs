using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacterTeleport : MonoBehaviour
{
    RubyController rScript;

    public GameObject firstFrog;
    public GameObject secondFrog;
    public GameObject simulation;
    // Start is called before the first frame update
    void Start()
    {
        rScript = GameObject.Find("ruby").GetComponent<RubyController>();
    }

    // Update is called once per frame
    void Update()
    {
       if(rScript.dialogCounter == 1)
       {
           firstFrog.SetActive(false);
           secondFrog.SetActive(true);
           
       }
       if(rScript.dialogCounter == 2)
       {
           simulation.SetActive(true);
       }
        
    }
}
