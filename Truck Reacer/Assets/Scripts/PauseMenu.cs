using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        //pauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void Resume ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Home()
    {   
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
