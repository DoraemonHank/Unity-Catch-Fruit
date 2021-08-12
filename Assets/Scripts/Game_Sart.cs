using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Sart : MonoBehaviour
{
    public static bool game_state = false; //遊戲還沒玩時,狀態為否,遊戲進行時為是
    public GameObject UI;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GameStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(1f);
        UI.SetActive(false);
        game_state = true; // 代表遊戲開始
    }
}
