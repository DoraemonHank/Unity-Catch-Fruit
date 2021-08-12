using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float Move_Speed = 5f;
    public Sprite[] Texture; // 貓咪貼圖
    public float sec = 0.2f; // 換圖的時間
    private int Num = 0; //換圖開關
    private bool Walk_State = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Sart.game_state == false) // 如果遊戲還沒開始,角色不能動
            return;

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Move_Speed * Time.deltaTime, 0, 0); // 向左邊移動
            transform.rotation = Quaternion.Euler(0, 180, 0); // 向左移動時,貓要轉向左邊

            // 換圖只執行一次
            if (Walk_State == false)
            {
                Walk_State = true;
                // 不斷重複某個動作
                InvokeRepeating(
                                "SetInterial", // 自訂function名
                                 0f,  // 開始時間
                                 sec  // 持續秒數
                                 );
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Move_Speed * Time.deltaTime, 0, 0); // 向左邊移動
            transform.rotation = Quaternion.Euler(0, 0, 0); // 向左移動時,貓要轉向左邊

            // 換圖只執行一次
            if (Walk_State == false)
            {
                Walk_State = true;

                // 不斷重複某個動作
                InvokeRepeating(
                            "SetInterial", // 自訂function名
                             0f,  // 開始時間
                             sec  // 持續秒數
                             );
            }
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow) || 
            Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
                    /*
                       按鍵起來時,
                       取消Invoke換貼圖
                     */
                CancelInvoke(); //取消Invoke換貼圖
                Walk_State = false;
        }

        if (transform.position.x > 6)
        {
            transform.position = new Vector3(6, transform.position.y, 0);
        }

        if (transform.position.x < -6)
        {
            transform.position = new Vector3(-6, transform.position.y, 0);
        }
    }

    void SetInterial()
    {
        /*
            如果Num等於0,
            使用Cat1貼圖
            如果Num等於1
            使用Cat2貼圖
        */
        if (Num == 0) 
        {
            //Debug.Log(Num);
            GetComponent<SpriteRenderer>().sprite = Texture[0]; // 換掉貼圖
            Num += 1;
        }
        else if (Num == 1) 
        {
            //Debug.Log(Num);
            GetComponent<SpriteRenderer>().sprite = Texture[1]; // 換掉貼圖
            Num -= 1;
        }
    }

   
}
