using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicController : MonoBehaviour
{
    private int puntuacao;
    public Text textPontuacao;
    public GameObject gameOverScreen;

    public void addScore()
    {
        puntuacao += 1;
        textPontuacao.text = puntuacao.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

