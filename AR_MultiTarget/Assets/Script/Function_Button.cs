using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Function_Button : MonoBehaviour {
    public GameObject UIStart;
    public void MulaiGame()
    {
        UIStart.SetActive(false);
    }
    public void Button_GantiScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
  
}
