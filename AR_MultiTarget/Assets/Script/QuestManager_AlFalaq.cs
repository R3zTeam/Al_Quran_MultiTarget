using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager_AlFalaq : MonoBehaviour {
    public Drag_to_unity[] Quest;
    public bool[] questComplete;

    public bool alltrue = true;

    // Use this for initialization
    void Start()
    {

        questComplete = new bool[Quest.Length];
    }

    // Update is called once per fram
    void Update()
    {
        for (int i = 0; i < questComplete.GetLength(0); i++)
        {
            if (questComplete[0] == true && questComplete[1] == true && questComplete[2] == true
                && questComplete[3] == true && questComplete[4] == true && questComplete[5] == true
                && questComplete[6] == true && questComplete[7] == true && questComplete[8] == true
                && questComplete[9] == true && questComplete[10] == true && questComplete[11] == true
                && questComplete[12] == true && questComplete[13] == true && questComplete[14] == true
                && questComplete[15])
            {
                Debug.Log("SELESAI");
            }


        }


    }
}
