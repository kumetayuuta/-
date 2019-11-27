using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrimScripts : MonoBehaviour
{
    float speed = 0;//キャラクター移動スピード
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.speed = 0f;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.speed = -0.2f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.speed = 0.2f;
        }
        transform.Translate(this.speed, 0,0);
    }
}
