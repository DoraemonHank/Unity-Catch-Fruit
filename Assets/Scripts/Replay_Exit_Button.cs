using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 控制遊戲場景

public class Replay_Exit_Button : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void replayFun()
    {
        SceneManager.LoadScene("PC"); //重新載入遊戲場景
    }

    public void exitFun()
    {
        Application.Quit();
    }
}
