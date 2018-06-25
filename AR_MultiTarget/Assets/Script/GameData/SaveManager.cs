using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {
    public GameData state;
    public static SaveManager Instance { set;get;}

    private void Awake()

        
    {
       

        DontDestroyOnLoad(gameObject);
        Instance = this;
        Load();
        Debug.Log(Helper.Serialize<GameData>(state));
    }
    public void Save()
    {
        PlayerPrefs.SetString("save",Helper.Serialize<GameData>(state));
        Debug.Log("Save");
    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("save"))
        {
            state = Helper.Deserialize<GameData>(PlayerPrefs.GetString("save"));
            Debug.Log("02");
        }
        else
        {
            state = new GameData();
            Save();
            Debug.Log("No Found Save, Creating New One");
        }
    }
}
