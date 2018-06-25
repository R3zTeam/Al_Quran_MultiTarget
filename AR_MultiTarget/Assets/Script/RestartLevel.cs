using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
    public Timer time;
    public void restartCurrentScene()
    {
        Timer.TimerDown = 0;
        time.score = 100;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Debug.Log("Active");
    }
}
