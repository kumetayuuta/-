using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlemSremAtk1 : MonoBehaviour
{
    public GameObject Atk1;//水の攻撃
    public GameObject Atk2;//炎の攻撃
    public GameObject Atk3;//雷の攻撃
    float span = 0.2f;
    float delta = 0;
    public Hensin kakunin;
    void Start()
    {
        
    }

    void Update()
    {
        if (kakunin.kakunin == 1)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))//水攻撃の生成と出る場所を変えている
            {

                GameObject go1 = Instantiate(Atk1) as GameObject;//生成
                Vector3 pos = transform.position;
                pos.x += transform.localScale.x;//炎を打つところを変えている　スケールを利用している
                pos.y += transform.localScale.y * 0.2f;//　　　　　　　〃
                go1.transform.position = pos;
                go1.transform.localScale = new Vector3(transform.localScale.x,//攻撃画像反転
                                                        go1.transform.localScale.y,
                                                        go1.transform.localScale.z
                                                        );
            }
        }
        if (kakunin.kakunin == 2)
        {
            if (Input.GetKey(KeyCode.Alpha2))//炎攻撃の生成と出る場所を変えている
            {
                this.delta += Time.deltaTime;
                if (this.delta > this.span)
                {
                    GameObject go2 = Instantiate(Atk2) as GameObject;//生成
                    this.delta = 0;
                    Vector3 pos2 = transform.position;
                    pos2.x += transform.localScale.x;
                    pos2.y += transform.localScale.y - 0.2f;
                    go2.transform.position = pos2;
                    go2.transform.localScale = new Vector3(transform.localScale.x,//攻撃画像反転
                                                        go2.transform.localScale.y,
                                                        go2.transform.localScale.z
                                                        );
                }
            }
        }
        if (kakunin.kakunin==3)
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))//雷攻撃の生成と出る場所を変えている
            {
                GameObject go3 = Instantiate(Atk3) as GameObject;//生成
                Vector3 pos3 = transform.position;
                pos3.x += transform.position.x + 10;
                pos3.y += transform.position.y + 7;
                go3.transform.position = pos3;
            }
        }
    }
}
