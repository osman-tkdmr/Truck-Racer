using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject options;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        options.SetActive(true);
        menu.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
