using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail_Raycast : MonoBehaviour
{
    public GameObject trail;
    private Ray ray;
    private RaycastHit hit; // 選3D射線的偵測方式
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 取得目前游標的位置,轉換成射線
                                                                 // 這句可以從攝像機發出一條射線

        // 射線是在三維世界中從一個點沿一個方向發射的一條無限長的線
        if (
            Input.GetMouseButton(0) && // 按下滑鼠才觸發
            Physics.Raycast( // 物理效果的射線
                ray, // 射線
                out hit // 可被射線觸碰的物件(碰到的物件為hit)
                        // 需產生一個GameObject來給hit碰,例如 GameObject3D的Quad,
                        // 把Quad拉滿整個頁面,並起把,Mesh Render關掉(不然遮擋住背景跟水果),
                        // 留下Mesh Collider給hit碰
                )
            )
        {
            trail.transform.position = hit.point; //射線的位置,賦予給物件位置
        }
    }
}
