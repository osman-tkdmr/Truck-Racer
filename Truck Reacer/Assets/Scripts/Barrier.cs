using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject dead;
    [SerializeField] GameObject score;
    [SerializeField] GameObject pause;

    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            pause.SetActive(false);
            score.SetActive(false);
            dead.SetActive(true);
            Time.timeScale = 0;
            audioManager.PlaySFX(audioManager.StopEngin);
        }
    }
}
