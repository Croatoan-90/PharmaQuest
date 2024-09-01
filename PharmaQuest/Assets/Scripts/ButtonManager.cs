using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GetMedSelectedInfo(GameObject button)
    {
        Singleton.selectedImage = button.GetComponent<Medicament>().medicamentImage;
        Singleton.selectedSymptomKey = button.GetComponent<Medicament>().sypmtomKey;
    }

    public void ChosenMedImage(GameObject medTrai)
    {
        medTrai.GetComponent<Image>().sprite = Singleton.selectedImage;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Shop()
    {
        SceneManager.LoadScene(2);
    }

    public void ExtraTimeBoost()
    {
         Singleton.time += 2;
        Singleton.pills -= 10;
    }

    public void ClueBoost()
    {
        BoostManager.instance.clue = true;
    }

    public void NewLifeBoost(Button button)
    {
        Singleton.pills -= 30;
        BoostManager.instance.newLife = true;
        button.gameObject.SetActive(false);
    }
}
