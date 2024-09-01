using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostManager : MonoBehaviour
{
    public static BoostManager instance;

    public Button extraLifeButton;
    public Button extraTimeButton;

    [HideInInspector]
    public bool clue;

    [HideInInspector]
    public bool newLife;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        ResetBoost();
    }

    // Update is called once per frame
    void Update()
    {
        if(Singleton.pills < 10)
        {
            extraTimeButton.gameObject.SetActive(false);
        }
        else
        {
            extraTimeButton.gameObject.SetActive(true);
        }

        if (Singleton.pills < 30) 
        { 
            extraLifeButton.gameObject.SetActive(false);
        }
        else
        {
            extraLifeButton.gameObject.SetActive(true);
        }

        if (newLife) 
        {
            if (Singleton.time < 1)
            {
                Singleton.time = 10;
                newLife = false;
            }
        }


    }

    public void ResetBoost()
    {
        newLife = false;
        clue = false;
        extraLifeButton.gameObject.SetActive(true);
    }
}
