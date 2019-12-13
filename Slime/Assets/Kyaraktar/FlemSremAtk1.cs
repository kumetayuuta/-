using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlemSremAtk1 : MonoBehaviour
{
    public GameObject Atk1;
    public GameObject Atk2;
    float span = 0.2f;
    float delta = 0;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))//水攻撃の生成と出る場所を変えている
        {
            GameObject go1 = Instantiate(Atk1) as GameObject;//生成
            Vector3 pos = transform.position;
            pos.x += transform.localScale.x;//炎を打つところを変えている　スケールを利用している
            pos.y +=transform.localScale.y*0.2f;//　　　　　　　〃
            go1.transform.position =pos;
            go1.transform.localScale = new Vector3(transform.localScale.x,
                                                    go1.transform.localScale.y,
                                                    go1.transform.localScale.z
                                                    );
        }
        if (Input.GetKey(KeyCode.Alpha2))//炎攻撃の生成と出る場所を変えている
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                GameObject go2 = Instantiate(Atk2) as GameObject;//生成
                this.delta = 0;
                Vector3 pos2 = transform.position;
                pos2.x += transform.localScale.x;
                pos2.y += transform.localScale.y * 0.2f;
                go2.transform.position = pos2;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))//雷攻撃の生成と出る場所を変えている
        {
            GameObject go3 = Instantiate(Atk1) as GameObject;//生成
            Vector3 pos3 = transform.position;
            pos3.x += transform.position.x+3;
            pos3.y += transform.position.y+3;
            go3.transform.position = pos3;
        }
    }
}
