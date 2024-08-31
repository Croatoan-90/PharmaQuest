using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Medicament : MonoBehaviour
{
    public int sypmtomKey;
    public string medicamentName;
    public Sprite medicamentImage;
    public TextMeshProUGUI nameTxt;
    
    private void Start()
    {
        nameTxt.text = medicamentName;
        gameObject.GetComponent<Image>().sprite = medicamentImage;
    }
}
