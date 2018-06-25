using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.UI;

using System.Runtime.Serialization.Formatters.Binary;
public class QuestManager : MonoBehaviour {
    [Header("Quest")]
    public Drag_to_unity[] Quest;
    public bool[] questComplete;


    public Timer TimeScoreing;
    public bool gameComplete = false;
    public bool alltrue ;

    public GameObject UIWin;
    public Text ScoreToUI;

    [Header("SaveGame")]
    public Game gameIsSave;
    public float WaktuDisimpan;
	// Use this for initialization
	void Start () {
		questComplete = new bool[Quest.Length];
	}
	
	// Update is called once per fram
	void Update () {
     
        check();
       
	}
    void check()
    {

        bool alltrue = false;
        foreach (bool b in questComplete)
        {
            if (b)
            {
                alltrue = true;
           
                
            }
            else
            {
                alltrue = false;           
                break;
            }

        }
        if (alltrue)
        {
            Debug.Log("Complete");
            UIWin.SetActive(true);
            gameComplete = true;
            ScoreToUI.text = TimeScoreing.Score;

            TimeScoreing.ScoreTime = false;
            TimeScoreing.timerIsActive = false;

            SettingSave();
           
        }
        else
        {
            Debug.Log("Not Complete");
        }
    }

    public void SettingSave()
    {
        if(Timer.tigaBintang == true)
        {
            gameIsSave.CheckLoadFile();
            WaktuDisimpan = Timer.TimerDown;


            if (gameIsSave.Waktu == 0)
            {
                gameIsSave.DBTotal = (int)WaktuDisimpan;
                gameIsSave.SaveGameVariable();
                Debug.Log("nol");
            }
            if (WaktuDisimpan < gameIsSave.Waktu)
            {
                gameIsSave.DBTotal = (int)WaktuDisimpan;
                gameIsSave.SaveGameVariable();
                Debug.Log("Tercepat");
            }
            
          
            
           
            //PlayerPrefs.SetInt("HealthKey", 3);
        }
        else if (Timer.duaBintang == true)
        {
            gameIsSave.CheckLoadFile();
            WaktuDisimpan = Timer.TimerDown;

            if (WaktuDisimpan < gameIsSave.Waktu)
            {
                gameIsSave.DBTotal = (int)WaktuDisimpan;
                gameIsSave.SaveGameVariable();
            }
           // PlayerPrefs.SetInt("HealthKey", 2);
        }
        else if (Timer.satuBintang == true)
        {
            gameIsSave.CheckLoadFile();
            WaktuDisimpan = Timer.TimerDown;

            if (WaktuDisimpan < gameIsSave.Waktu)
            {
                gameIsSave.DBTotal = (int)WaktuDisimpan;
                gameIsSave.SaveGameVariable();
            }
            //PlayerPrefs.SetInt("HealthKey", 1);            
        }
        
    }
    
}
