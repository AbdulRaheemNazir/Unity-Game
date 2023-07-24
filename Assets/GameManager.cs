using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //refrences
    public GameObject gameOverCanvas;
    public GameObject getReady;
    public GameObject score;
    public GameObject pauseBtn;
    public static Vector2 bottomLeft;
    public Animator blackFadeAnim;
    int drawScore;
    //Game States
    public static bool gameOver;
    bool touchedGround;
    public static bool gameHasStarted;
    public static bool gameIsPaused;
    public static int gameScore;
    public Text panelScore;

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
    }


    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameHasStarted = false;
        gameIsPaused = false;

    }

    public void GameHasStarted()
    {
        gameHasStarted = true;
        score.SetActive(true);
        getReady.SetActive(false);
        pauseBtn.SetActive(true);

    }






    public void GameOver()
    {
        gameOver = true;
        gameScore = score.GetComponent<Score>().GetScore();
        score.SetActive(false);
        Invoke("ActivateGameOverCanvas", 1);
        pauseBtn.SetActive(false);
    }

    void ActivateGameOverCanvas()
    {
        gameOverCanvas.SetActive(true);
    }



    public void OnOkBtnPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void OnMenuBtnPressed()
    {
        SceneManager.LoadScene("Menu");
        blackFadeAnim.SetTrigger("fadeIn");

    }

    public void DrawScore()
    {
        if(drawScore <= gameScore)
        {
            panelScore.text = drawScore.ToString();
            drawScore++;
            Invoke("DrawScore", 0.05f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
