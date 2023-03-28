using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public TMP_Text timeText;
    public TMP_Text scoreText;

    public TMP_Text winScore;
    public TMP_Text winText;
    public GameObject winStarts1, winStarts2, winStarts3;

    public GameObject roundOverScreen;

    private Board theBoard;

    public string LevelSelect;

    public GameObject pauseScreen;

    private void Awake()
    {
        theBoard = FindObjectOfType<Board>();
    }

    private void Start()
    {
        winStarts1.SetActive(false);
        winStarts2.SetActive(false);
        winStarts3.SetActive(false);
    }

    public void PauseUnpause()
    {
        if(!pauseScreen.activeInHierarchy)
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void ShuffleBoard()
    {
        theBoard.ShuffleBoard();
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }

    public void GoTOLevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(LevelSelect);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 


}
