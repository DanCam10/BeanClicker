using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Restart()
    {
        Global.hasWonGame = true;
        SceneManager.LoadScene("TitleScreen");
    }
}
