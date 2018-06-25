using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_to_unity : MonoBehaviour {
    public GameObject objectToDrag;
    public GameObject objectDrag;

    public int questNumber;
    public QuestManager Qm;

    public bool isComplete;
    public AudioSource Audio;
    public AudioClip ClickedSound;
    // Use this for initialization
    float angka;


    Collider m_Collider;
	void Start () {
        m_Collider = GetComponent<Collider>();
        Audio = GetComponent<AudioSource>();
    }
    void DefaultPosition()
    {
        
      
        
    }

	// Update is called once per frame
	void Update () 
    {

        float distance = Vector3.Distance(objectDrag.transform.position, objectToDrag.transform.position);

      
        if (Input.GetMouseButtonUp(0))
        {
            if (distance < 0.5)
            {
                if (objectDrag.GetComponent<Identy>().kode == objectToDrag.GetComponent<Identy>().kode)
                {
                    objectDrag.transform.position = objectToDrag.transform.position;
                    //Debug.Log("Match");
                    Qm.questComplete[questNumber] = true;
                    isComplete = true;
                    m_Collider.enabled = false;

                    if (isComplete)
                    {
                        Audio.PlayOneShot(ClickedSound);    
                    }

                    
                }
                else
                {
                    Debug.Log("Not Match");

                    m_Collider.enabled = true;
                }


            } 
        }
	}

    public void OnFingerDown()
    {
        
        float distance = Vector3.Distance(objectDrag.transform.position, objectToDrag.transform.position);
       
        if (distance < 1)
        {
            if (objectDrag.GetComponent<Identy>().kode == objectToDrag.GetComponent<Identy>().kode)
            {
                objectDrag.transform.position = objectToDrag.transform.position;
                Debug.Log("Match");
            }
            else 
            {
                Debug.Log("Not Match");
            }


        }

    }
}
