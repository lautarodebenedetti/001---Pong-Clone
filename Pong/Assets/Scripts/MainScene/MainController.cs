using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayPlayer1()
    {
        Configuration.ONE_PLAYER = true;
        SceneManager.LoadScene(1);
    }

    public void PlayPlayer2()
    {
        Configuration.ONE_PLAYER = false;
        SceneManager.LoadScene(1);
    }

    public void ChangeSound(Text text)
    {
        if (text.text == "Sound: Off")
        {
            text.text = "Sound: On";
            AudioListener.pause = false;
        }
        else
        {
            text.text = "Sound: Off";
            AudioListener.pause = true;
        }

    }
}
