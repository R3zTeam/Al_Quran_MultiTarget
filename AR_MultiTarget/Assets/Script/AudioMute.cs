using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMute : MonoBehaviour {
    public Image imgsatu;
    [Space]
    public Sprite yellowStar;
    public Sprite ImageDefault;
    bool OnOff;
    public void Start()
    {

    }
    public void AudioOff()
    {

        OnOff = !OnOff;
        AudioListener.pause = !AudioListener.pause;
        if (OnOff)
        {

            imgsatu.sprite = yellowStar;

        }
        else
        {
            imgsatu.sprite = ImageDefault;
        }
    }
}
