using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveDataScript : MonoBehaviour {
    public static int healthValue = 0;
    public static int beforeLoadValue = 0;
    private int total = 0;
    private int fTotal = 0;
    public Text Texting;
	// Use this for initialization
	void Awake () {
        Save();
        Load();
	}
    void LateUpdate()
    {
        
        Load();
        //PlayerPrefs.SetInt("hasPlayedLevel1", 1);
        checkSaveGame();
    }
	// Update is called once per framelic 

    public void Next()
    {
        healthValue++;
        Texting.text = healthValue.ToString();
    }
    public void Save()
    {

       
        PlayerPrefs.SetInt("Total", total);
        PlayerPrefs.SetInt("HealthKey",healthValue);

    }
    public void Load()
    {

        healthValue = PlayerPrefs.GetInt("HealthKey", healthValue);

        if (PlayerPrefs.HasKey("HealthKey"))
        {
           
            Texting.text = healthValue.ToString() + " / 9";
        }
        else
        {
            Texting.text = "Data Not Valid";
        }
        
    }
    

    public void checkSaveGame()
    {
        bool hasplayedLevel = false;
        if (PlayerPrefs.GetInt("hasPlayedLevel1") == healthValue)
        {
            hasplayedLevel = true;
        }
        else
        {
            hasplayedLevel = false;
        }



        if (hasplayedLevel)
        {
            //TestAdaGA.SetActive(true);
            //Debug.Log("ada");
        }
        else
        {
            //TestAdaGA.SetActive(false);
            //Debug.Log("Tidak ada");
            
        }
    }
}
