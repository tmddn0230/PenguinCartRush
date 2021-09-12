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
        scoreText.text = "현재 점수 : " + score;
    }

    void Update()
    {
        if(gameOver.activeSelf == false)
        {
         distance += Time.deltaTime;
         distanceText.text = "이동 거리 : " + (int)distance + "M"; 
        }
    }

    public void AddScoreThree()
    {
        score += 3;
        scoreText.text = "현재 점수 : " + score;
    }

    public void AddScoreFive()
    {
        score += 5;
        scoreText.text = "현재 점수 : " + score;
    }

    public void RemoveLife()
    {
        Destroy(lifes[lifeCnt]);
        lifeCnt++;

        if(lifeCnt == 3)
        {
            gameOver.SetActive(true);
            soundManager.SetActive(false);
            fixedScore.text = " 최종 점수 : " + score;
            fixedDistance.text = " 최종 이동거리 : " + (int)distance + "M";
        }
    }
}
