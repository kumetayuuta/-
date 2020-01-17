using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScripts : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float speed = 0;//キャラクター移動スピード
    public bool jp = true;//ジャンプ中はtrue
    public float Jamp= 300.0f;//キャラクタージャンプ距離
    int key = 0;
    float span = 0.8f;
    float delta = 0;
    void Start()
    {
        this.rigidbody2D = GetComponent<Rigidbody2D>();
        Jamp = 3f * Time.deltaTime;
    }
    void Update()
    {
        Move();
        this.delta += Time.deltaTime;
        //接地していて上キー入力があった場合ジャンプできるようにする
        if (!jp && Input.GetKey(KeyCode.Space))
        {
            jp = true;
            Jump();
        }
    }
    void Jump()
    {
        // 現在の加速度（rigidbodyの）を取得
        Vector2 velocity = rigidbody2D.velocity;
        // ジャンプ量を y (縦) 方向に代入
        velocity.y = Jamp;
        // 代入加速度へ変更
        rigidbody2D.velocity = velocity;
    }
    // 地面にぶつかった瞬間に呼び出される
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Groun")
        {
            jp = false;
        }
    }
    void Move()//左右移動
     {
        transform.Translate(this.speed, 0, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))//右矢印が押されている間右に移動
        {
            this.speed = 0.05f;
            key = 1;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))//右矢印が押されていない間速度を０にする
        {
            this.speed = 0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//左矢印が押されている間左に移動
        {
            this.speed = -0.05f;
            key = -1;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))//左矢印が押されていない間速度を０にする
        {
            this.speed = 0.0f;
        }
        if (key!=0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }

}
