using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer Instance;
    public TextMeshProUGUI timeText;

    [HideInInspector]
    public bool timeController;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Singleton.time > 0)
        {
            if (timeController)
            {
                Singleton.time -= Time.deltaTime;
            }

        } else
        {
            Singleton.time = 0;
        }
        DisplayTime(Singleton.time);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        timeText.text = "Time: " + string.Format("{0:00}", timeToDisplay);
    }

    public void TimeController()
    {
        timeController = false;
    }

}
