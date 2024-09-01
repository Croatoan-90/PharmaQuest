using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostManager : MonoBehaviour
{
    public static BoostManager instance;

    [HideInInspector]
    public bool extraTime;

    [HideInInspector]
    public bool clue;

    [HideInInspector]
    public bool newLife;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        extraTime = false;
        newLife = false;
        clue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
