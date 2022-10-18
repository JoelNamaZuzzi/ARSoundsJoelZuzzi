using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceScript : MonoBehaviour
{
    [SerializeField] private AudioSource Sauce;
    private bool isOn=false;

    public void ToggleAudio()
    {
        if (isOn)
        {
            Sauce.Stop();
            isOn = false;
        }
        else
        {
            Sauce.Play();
            isOn = true;
        }
    }
}
