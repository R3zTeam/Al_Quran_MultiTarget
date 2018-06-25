using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinStar : MonoBehaviour {
    public Image imgsatu, imgdua, imgtiga;
    [Space]
    public Sprite yellowStar;
    public Sprite grayStar;
    [Space]
    public Timer timeManager;
    [Space]

    Animator Anim;
	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Timer.tigaBintang)
        {
            Anim.SetTrigger("TriggerThree");
        }
        else if (Timer.duaBintang)
        {
            Anim.SetTrigger("TriggerTwo");
        }
        else
        {
            Anim.SetTrigger("TriggerOne");
        }
	}
    

    
}
