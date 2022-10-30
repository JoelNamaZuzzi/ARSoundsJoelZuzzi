using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioSourceScript : MonoBehaviour
{
    [SerializeField] private AudioSource Sauce;
    private bool isOn=false;
    [SerializeField] private TMP_Text VolTXT;
    [SerializeField] private TMP_Text PitchTXT;
    [SerializeField] private TMP_Text BlendTXT;
    [SerializeField] private TMP_Text FalloffTXT;
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

    public void chngVolume(float value)
    {
        Sauce.volume = value;
        VolTXT.text = value.ToString("F2");
    }
    public void chngPitch(float value)
    {
        Sauce.pitch = value;
        PitchTXT.text = value.ToString("F2");
    }
    public void chngBlend(float value)
    {
        Sauce.spatialBlend = value;
        BlendTXT.text = value.ToString("F2");
    }

    public void chngFalloff(float value)
    {
        Sauce.maxDistance = value;
        FalloffTXT.text = value.ToString("F0");
    }
}
