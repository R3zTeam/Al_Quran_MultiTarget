using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLoadGame : MonoBehaviour {

    public Game gameIsSave;
    public void Update()
    {
        gameIsSave.LoadGameVariable();
        
    }
}
