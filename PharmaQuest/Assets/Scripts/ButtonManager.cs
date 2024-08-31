using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Singleton.selectedSymptomKey);
    }

    public void GetMedSelectedInfo(GameObject button)
    {
        Singleton.selectedImage = button.GetComponent<Medicament>().medicamentImage;
        Singleton.selectedSymptomKey = button.GetComponent<Medicament>().sypmtomKey;
    }
}
