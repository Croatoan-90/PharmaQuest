using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SymptomsManager : MonoBehaviour
{
    public GameObject []  symptomKeys;
    public GameObject nextPatient;
    public int totalSymptoms;
    private int indexNegative;
    private int indexPositive;

    private Image medChosen;

    public Button nextButton;

    public int lvl;

    public float timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        nextButton.gameObject.SetActive(false);
        medChosen = GameObject.Find("MedChosen").GetComponent<Image>();
        Singleton.time = timeLimit;
        Timer.Instance.timeController = true;
        medChosen.sprite = null;
    }

    private void Update()
    {
        /*if(indexNegative == totalSymptoms)
        {
            //symptomKeys[0].GetComponent<Symptom>().symptomKey.ToString();
            
            Debug.Log("Failed");
        }*/

        if(indexPositive == totalSymptoms)
        {
            Timer.Instance.TimeController();
            nextButton.gameObject.SetActive(true);
            
        }
    }

    public void CheckSymptom()
    {
        for (int i = 0; i < symptomKeys.Length; i++)
        {
            if(symptomKeys[i].GetComponent<Symptom>().symptomKey == Singleton.selectedSymptomKey)
            {
                symptomKeys[i].GetComponent<Symptom>().check.SetActive(true);
                indexPositive++;
                medChosen.sprite = null;
                return;
            }
            else
            {
                indexNegative++;
                if (indexNegative == totalSymptoms)
                {
                    Singleton.time -= 2;
                }
                medChosen.sprite = null;
            }

        }
        
    }

    public void NextPatient()
    {
        gameObject.SetActive(false);
        nextPatient.SetActive(true);
        Singleton.lvl = lvl;
        
    }
 
}
