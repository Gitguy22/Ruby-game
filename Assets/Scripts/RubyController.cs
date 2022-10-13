using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");

        // Declared position variable and set it equal to players position
       Vector2 position = transform.position;
       // Update players x position .1 unit every frame
       position.x = position.x + 3.0f * horizontal * Time.deltaTime;
       position.y = position.y + 3.0f * vertical * Time.deltaTime;
       transform.position = position;   
    }
}
