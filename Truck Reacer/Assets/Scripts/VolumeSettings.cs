using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SFXSlider;

    public void setMusicVolume()
    {
        float Musicvolume = musicSlider.value;
        myMixer.SetFloat("Music", Musicvolume);
    }
    public void setSFXVolume()
    {
        float SFXvolume = SFXSlider.value;
        myMixer.SetFloat("SFX", SFXvolume);
    }
}
