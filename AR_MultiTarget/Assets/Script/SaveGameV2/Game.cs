using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

using System.Runtime.Serialization.Formatters.Binary;

public class Game : MonoBehaviour {
    public int hits;
    public int shots;
    public int totalNilai;

    [Header("Total Final")]
    public int finalTotal;
    public Text Tester;

    [Space]
    [Header("DataBase Total")]

    public int DBTotal;
    public int Waktu;
    

    private VariableData CreateVariableSave()
    {

        VariableData vbData = new VariableData();


        vbData.NilaiDB = DBTotal;


        return vbData;
    }
    public void NextValue()
    {
        DBTotal++;
        Tester.text = DBTotal.ToString();

    }


    private Save CreateSaveGameObject()
    {
        
        Save save = new Save();
        

        save.hits = hits;
        save.shots = shots;
        save.totalNilai = totalNilai;
        save.finalTotal = finalTotal;

        return save;
    }
    public void SaveGame()
    {
        // 1
        

        Save save = CreateSaveGameObject();

        // 2
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        Tester.text =  hits.ToString();

        Debug.Log("Game Saved");
    }

    public void SaveGameVariable()
    {

        VariableData vbData = CreateVariableSave();

        BinaryFormatter vBFormater = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/variableGame.save");
        vBFormater.Serialize(file, vbData);
        file.Close();

        
        Tester.text = DBTotal.ToString();

        Debug.Log("Saved");

    }


    public void LoadGame()
    {
        
        // 1
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
           
            // 2
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            // 3
            

            // 4
           
            shots = save.shots;
            hits = save.hits;

            
            Tester.text = hits.ToString();

            Debug.Log("Game Loaded");

        }
        else
        {
            Debug.Log("No game saved!");
        }
    }
    public void CheckLoadFile()
    {
     
            //CheckSaveGame
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();
            

            //check DB 
            BinaryFormatter DbData = new BinaryFormatter();
            FileStream fileVariable = File.Open(Application.persistentDataPath + "/variableGame.save", FileMode.Open);
            VariableData vbData = (VariableData)DbData.Deserialize(fileVariable);
            fileVariable.Close();

             Waktu = vbData.NilaiDB ;

            
             //save.shots = shots; udah terdefinisi

             

            
             
            
            
    }
    public void Reset()
    {
        hits = 0;
        finalTotal = 0;
        shots = 0;
        totalNilai = 0;
    }

    public void LoadGameVariable()
    {

        // 1
        if (File.Exists(Application.persistentDataPath + "/variableGame.save"))
        {


            // 2
            BinaryFormatter DbData = new BinaryFormatter();
            FileStream fileVariable = File.Open(Application.persistentDataPath + "/variableGame.save", FileMode.Open);
            VariableData vbData = (VariableData)DbData.Deserialize(fileVariable);
            fileVariable.Close();


           DBTotal = vbData.NilaiDB;


           int min = Mathf.FloorToInt(DBTotal / 60);
           int sec = Mathf.FloorToInt(DBTotal % 60);

           Tester.text = min.ToString("00") + ":" + sec.ToString("00");
           
        }
        else
        {
            DBTotal = 0;
            SaveGameVariable();
        }
    }
   
}
