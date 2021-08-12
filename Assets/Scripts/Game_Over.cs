using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    public GameObject UI;
    public GameObject Replay_Btn;
    public GameObject Exit_Btn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Score_Time.timeNum <= 0)
        {
            Game_Sart.game_state = false;
            StartCoroutine("Show_UI"); // 延遲一下再出現按紐
            
        }
    }

    IEnumerator  Show_UI()
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        Replay_Btn.SetActive(true);
        Exit_Btn.SetActive(true);
    }
}
