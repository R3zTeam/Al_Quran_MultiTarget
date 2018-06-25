using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    [Header("TimerScore")]
    public Text ScoreText;

    private float timer;
    public bool ScoreTime = true;
    
    public int score = 100;

    [Header("Timer")]
    public bool timerIsActive = false;
    public static float TimerDown = 0;
    private Text timerText;



    public float bintangTiga, bintangDua, bintangSatu;
    public Text tes;
  
    [Space]
    [Header("Scoring")]
    public string Score;
    public QuestManager QM;

    [Space]

    public static bool tigaBintang, duaBintang, satuBintang = false;
	// Use this for initialization
    void Awake()
    {
        TimerDown = 0;
        score = 100;
    }
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        // Score TO minute or second
        int min = Mathf.FloorToInt(TimerDown / 60);
        int sec = Mathf.FloorToInt(TimerDown % 60);

        score = Mathf.Clamp(score, 31, 100);
        //Score -  Time
        skoring();
       
        //

        if (timerIsActive)
        {

            TimerDown += Time.deltaTime;
            timerText.text = min.ToString("00") + ":" + sec.ToString("00");
            //timerText.text = TimerDown.ToString("f0");               
        }

        if (TimerDown < bintangTiga && QM.gameComplete == true)
        {
            
            Score = Score.ToString();
            Score = score.ToString();
            tigaBintang = true;
        }
        else if (TimerDown < bintangDua && QM.gameComplete == true)
        {
            Score = Score.ToString();
            Score = score.ToString();

            duaBintang = true;
        }
        else if (TimerDown < bintangSatu && QM.gameComplete == true)
        {
            Score = Score.ToString();
            Score = score.ToString();

            satuBintang = true;
        }
            
                    

	}
    public void skoring()
    {
        if (TimerDown >= 1)
        {
            if (ScoreTime)
            {
                timer += Time.deltaTime;
                if (timer > 60f)
                {

                    score -= 1;

                    //We only need to update the text if the score chimanged.
                    ScoreText.text = score.ToString();

                    //Reset the timer to 0.
                    timer = 0;
                }

            }

        }

    }
}
