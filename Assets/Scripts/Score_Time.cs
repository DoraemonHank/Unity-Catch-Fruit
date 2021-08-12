using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score_Time : MonoBehaviour
{
    public static int scoreNum;
    public static float timeNum;
    public Sprite[] texture;
    public GameObject[] scoreUI;
    public GameObject[] timeUI;


    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0; // 初始化分數
        timeNum = 120f; // 初始化秒數
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Sart.game_state == false) // 如果遊戲還沒開始,就不開始計時
            return;
        if (timeNum > 0)
            timeNum -= Time.deltaTime;
        setTimeAndScoreUI<float>(timeUI, timeNum);
        setTimeAndScoreUI<int>(scoreUI, scoreNum);


    }

    
    private void setTimeAndScoreUI<T>(GameObject[] obj,T num)
    {
        int ts_num;
        ts_num = (int)Convert.ChangeType(num, typeof(int));

        if (ts_num <= 0)
        {
            obj[0].SetActive(true);
            obj[1].SetActive(false);
            obj[2].SetActive(false);
            obj[0].GetComponent<SpriteRenderer>().sprite = texture[0];
        }

        if (ts_num > 0 && ts_num < 10)
        {
            obj[0].SetActive(true);
            obj[1].SetActive(false);
            obj[2].SetActive(false);
            obj[0].GetComponent<SpriteRenderer>().sprite = texture[(int)ts_num];
        }
        else if (ts_num >= 10 && ts_num < 100)
        {
            int tens = ((int)ts_num) / 10;
            int units = ((int)ts_num) % 10;

            obj[0].SetActive(true);
            obj[1].SetActive(true);
            obj[2].SetActive(false);
            obj[0].GetComponent<SpriteRenderer>().sprite = texture[tens];
            obj[1].GetComponent<SpriteRenderer>().sprite = texture[units];
        }
        else
        {
            int hundreds = ((int)ts_num) / 100;
            int tens = ((int)ts_num) % 100 / 10;
            int units = ((int)ts_num) % 10;

            obj[0].SetActive(true);
            obj[1].SetActive(true);
            obj[2].SetActive(true);
            obj[0].GetComponent<SpriteRenderer>().sprite = texture[hundreds];
            obj[1].GetComponent<SpriteRenderer>().sprite = texture[tens];
            obj[2].GetComponent<SpriteRenderer>().sprite = texture[units];
        }
    }
}
