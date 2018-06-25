using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour {

	// Use this for initialization
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public Image BackGroundBlur;

    public Timer time;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPause = false;
        pauseButton.SetActive(true);
        BackGroundBlur.enabled = false;
        time.timerIsActive = true;
    }
    public void Pause()
    {
        
        pauseMenuUI.SetActive(true);
        GameIsPause = true;
        pauseButton.SetActive(false);
        BackGroundBlur.enabled = true;
        time.timerIsActive = false;
    }
}
