using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Myself : MonoBehaviour
{
    public float rotate_x, rotate_y;
    private float rotate_z;
    Random rand = new Random();

    // Start is called before the first frame update
    void Start()
    {
        rotate_z = Random.Range(-360.0f, 360.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(rotate_x * Time.deltaTime, rotate_y * Time.deltaTime, rotate_z * Time.deltaTime);
    }
}
