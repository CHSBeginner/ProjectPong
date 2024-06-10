using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreBlue = 0;
    public int PlayerScoreRed = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreblue;
    public TMP_Text txtPlayerScoreRed;

    public static GameManager instance;
    public void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void Poin(string sideWallName)
    {
        if (sideWallName == "Left") PlayerScoreRed += 1;
        else PlayerScoreBlue += 1;
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtPlayerScoreblue.text = PlayerScoreBlue.ToString();
        txtPlayerScoreRed.text = PlayerScoreRed.ToString();
    }


    //Method penyeleksi untuk menambah score
    public void ScoreWall(string wallID)
    {
        if (wallID == "Line Left")
        {
            PlayerScoreRed = PlayerScoreRed + 1; //Menambah score
            txtPlayerScoreRed.text = PlayerScoreRed.ToString(); //Mengisikan nilai integer PlayerScore ke UI
        }
        else
        {
            PlayerScoreBlue = PlayerScoreBlue + 1;
            txtPlayerScoreblue.text = PlayerScoreBlue.ToString();

        }
    }

    public void ScoreCheck()
    {
        if (PlayerScoreBlue == 10)
        {
            Debug.Log("playerL win");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
        else if (PlayerScoreRed == 10)
        {
            Debug.Log("playerR win");
            this.gameObject.SendMessage("ChangeScene", "MainMenu");
        }
    }

    public void Score(string wallID)
    {
        if (wallID == "Line Left")
        {
            //StartCoroutine(ShakeCam(0.7f));
            PlayerScoreRed = PlayerScoreRed + 1; //menambah score
            txtPlayerScoreRed.text = PlayerScoreRed.ToString(); //mengisikan nilai integer PlayerScore ke UI
            ScoreCheck();
        }
        else
        {
            //StartCoroutine(ShakeCam(0.7f));
            PlayerScoreBlue = PlayerScoreBlue + 1;
            txtPlayerScoreblue.text = PlayerScoreBlue.ToString();
            ScoreCheck();
        }
    }
}