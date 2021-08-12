using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Fruits : MonoBehaviour
{
    public GameObject[] fruits;
    public float sec = 2; // 每幾秒生出水果
    private Vector3 x_num; // 水平位置,隨機生成水果位置
    private int fruit_num; // 判別生出哪種水果
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SetInterial", 0f, sec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetInterial()
    {
        if (Game_Sart.game_state == false) // 如果遊戲還沒開始,就不掉水果
            return;
        
        // -4~-1 往左邊
        // 0 中間
        // 1~4 往右邊
        x_num.x = Random.Range(-4, 5);
        transform.position += new Vector3(x_num.x, 0, 0); // 生成點的位置

        // 限制水果產生範圍,不要超出背景
        if (transform.position.x > 6)
            transform.position = new Vector3(6, transform.position.y, 0);
        if (transform.position.x < -6)
            transform.position = new Vector3(-6, transform.position.y, 0);

        // 生出水果種類(0~4種)
        fruit_num = Random.Range(0, 5);

        // 生成水果
        Instantiate(fruits[fruit_num], transform.position, transform.rotation);
    }
}
