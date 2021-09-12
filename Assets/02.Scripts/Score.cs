using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    private float distance = 0;
    public Text distanceText;

    public GameObject[] lifes;
    int lifeCnt = 0;

    public GameObject gameOver;
    public Text fixedScore;
    public Text fixedDistance;


    public GameObject soundManager;

    void Start()
    {
        scoreText.text = "���� ���� : " + score;
    }

    void Update()
    {
        if(gameOver.activeSelf == false)
        {
         distance += Time.deltaTime;
         distanceText.text = "�̵� �Ÿ� : " + (int)distance + "M"; 
        }
    }

    public void AddScoreThree()
    {
        score += 3;
        scoreText.text = "���� ���� : " + score;
    }

    public void AddScoreFive()
    {
        score += 5;
        scoreText.text = "���� ���� : " + score;
    }

    public void RemoveLife()
    {
        Destroy(lifes[lifeCnt]);
        lifeCnt++;

        if(lifeCnt == 3)
        {
            gameOver.SetActive(true);
            soundManager.SetActive(false);
            fixedScore.text = " ���� ���� : " + score;
            fixedDistance.text = " ���� �̵��Ÿ� : " + (int)distance + "M";
        }
    }
}
