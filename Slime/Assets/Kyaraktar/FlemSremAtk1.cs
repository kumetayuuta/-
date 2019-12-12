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
        if (Input.GetKeyDown(KeyCode.Alpha1))//１が押されたら
        {
            transform.Translate(0.1f, 0, 0);//１フレームごとに横に移動していく
            GameObject go = Instantiate(Flemsrematk１) as GameObject;
            this.delta += Time.deltaTime;
            go.transform.position =new Vector3(0, 0, 0);
            if (this.delta > this.Span)
            {
                this.delta = 0;
            }
        }
    }
}
