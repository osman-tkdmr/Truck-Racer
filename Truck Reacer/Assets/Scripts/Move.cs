using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Move : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI deadText;
    [SerializeField] TextMeshProUGUI highscore;
    [SerializeField]  private float speed;
    private float sayac = 1;
    private float ax;
    private int score = 0;
    private int highScore = 0;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Start()
    {
        highScore = PlayerPrefs.GetInt(nameof(highScore));
        audioManager.PlaySFX(audioManager.StartEngin);

    }

    private void Update()
    {
        float nextPosZ = Mathf.Clamp(transform.position.z + (-Input.GetAxis("Horizontal") / 10), -5, 5);
        transform.position = new Vector3(transform.position.x, transform.position.y, nextPosZ);

        //idle
        speed -= 1 * Time.deltaTime/2;

        ax = Input.GetAxis("Vertical") * Time.deltaTime;

        if (Input.GetAxis("Vertical") > 0)
            speed += ax * 150/speed;
        else
            speed += ax * 40;
        

        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        

        speed = Mathf.Clamp(speed, 10, 150);
        sayac += 1 * Time.deltaTime * speed / 10;
        score = (int)Mathf.Round(sayac);

        if (score > highScore)
            highScore = score;
        
        PlayerPrefs.SetInt(nameof(highScore), highScore);

        scoreText.text = "Score\n" + score.ToString();
        deadText.text = scoreText.text;
        highscore.text = "High Score\n" + highScore.ToString();

    }
     
}

