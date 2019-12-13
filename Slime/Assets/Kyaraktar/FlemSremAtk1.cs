using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlemSremAtk1 : MonoBehaviour
{
    public GameObject FlemAtk1;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))//生成と出る場所を変えている
        {
            GameObject go = Instantiate(FlemAtk1) as GameObject;//生成
            Vector3 pos = transform.position;
            pos.x += transform.localScale.x;//炎を打つところを変えている　スケールを利用している
            pos.y +=transform.localScale.y*0.4f;//　　　　　　　〃
            go.transform.position =pos;
        }
    }
}
