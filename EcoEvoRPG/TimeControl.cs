using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FastForward();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SlowDown();
        }
    }

    void FastForward()
    {
        Time.timeScale += 1;
        Debug.Log("Time" + Time.timeScale);
    }
    void SlowDown()
    {
        Time.timeScale -= 1;
        Debug.Log("Time" + Time.timeScale);
    }
}
