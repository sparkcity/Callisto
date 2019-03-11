using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public VectorValue startingPosition;
    public Vector2 playerPosition;

    public void play()
    {
        startingPosition.initValue = playerPosition;
        SceneManager.LoadScene("BaseScene");
    }

    public void tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void kallisto()
    {
        SceneManager.LoadScene("Kallisto");
    }

    public void quit()
    {
        Application.Quit();
    }
}
