using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Up : MonoBehaviour
{
    public int up_speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, up_speed * Time.deltaTime, 0);
        Destroy(gameObject, 0.5f);
    }
}
