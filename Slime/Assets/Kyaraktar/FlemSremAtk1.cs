using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlemSremAtk1 : MonoBehaviour
{
    public GameObject Flemsrematk１;
    float Span = 3.0f;
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0.1f, 0, 0);//１フレームごとに横に移動していく
        if (Input.GetKeyDown(KeyCode.Alpha1))//１が押されたら
        {
            GameObject go = Instantiate(Flemsrematk１) as GameObject;
            this.delta += Time.deltaTime;
            if (this.delta > this.Span)
            {
                Destroy(gameObject);
                this.delta = 0;
            }
        }
    }
}
