using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip Background;
    public AudioClip SFXClip;
    public AudioClip StartEngin;
    public AudioClip StopEngin;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
        SFXSource.clip = SFXClip;
        SFXSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
