using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory_Myself : MonoBehaviour
{
    public string trigger_tag;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == trigger_tag)
        {
            Destroy(gameObject);
        }
    }
}
