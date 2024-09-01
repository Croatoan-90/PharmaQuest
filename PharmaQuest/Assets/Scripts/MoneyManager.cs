using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI generalPills;

    public TextMeshProUGUI generalMedkit;
    
    // Update is called once per frame
    void Update()
    {
        generalPills.text = Singleton.pills.ToString();
        generalMedkit.text = Singleton.medkit.ToString();
    }
}
