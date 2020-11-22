using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Text startButtonText;
    public GameObject newGameButton;

    private void Start()
    {
        newGameButton.SetActive(false);

        if (Global.hasWonGame)
        {
            startButtonText.text = "Continue";
            newGameButton.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
