using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch_Fruit : MonoBehaviour
{
    public AudioClip catch_sound;
    public GameObject[] show_score;
    public float y_num = 0.5f;
    private Vector3 y_pos;
    private Dictionary<string, int> fruit_score = new Dictionary<string, int> {
                                                                                {"Watermelon",20 },
                                                                                {"Banana",10 },
                                                                                {"Apple",8 },
                                                                                {"Orange",5 },
                                                                                {"Strawberry",2 }
                                                                            };

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
        y_pos.y = y_num;
        collision.transform.position += y_pos;

        int i = 0;
        foreach (KeyValuePair<string,int> item in fruit_score)
        {
            if (collision.gameObject.tag == item.Key)
            {
                Score_Time.scoreNum += item.Value;
                Instantiate(show_score[i], collision.transform.position,
                    Quaternion.Euler(0, 0, 0) // transform.rotation的話,貓咪反向(向左)分數方向也會相反,所以方向都設定為0
                    );
            }
            i++;
        }
       // Debug.Log(Score_Time.scoreNum);
        GetComponent<AudioSource>().PlayOneShot(catch_sound);
        Destroy(collision.gameObject);
    }
}
