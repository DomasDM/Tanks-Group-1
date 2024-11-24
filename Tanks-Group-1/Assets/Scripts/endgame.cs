using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endgame : MonoBehaviour
{
    public Text winnerText;

    void Start()
    {
        string winner = PlayerPrefs.GetString("Winner", "No one");
        GetComponent<endgame>().DisplayWinner(winner);
    }

    public void DisplayWinner(string playerName)
    {
        winnerText.text = "Winner: " + playerName;
    }

    public void LoadIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
