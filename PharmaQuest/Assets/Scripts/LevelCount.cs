using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelCount : MonoBehaviour
{

    public TextMeshProUGUI lvl;

    // Update is called once per frame
    void Update()
    {
        lvl.text = "Lvl: 0" + Singleton.lvl.ToString();
    }
}
