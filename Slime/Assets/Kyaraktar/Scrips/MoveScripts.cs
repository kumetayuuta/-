using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScripts : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float speed = 0;//キャラクター移動スピード
    public bool jp = true;//ジャンプ中はfalse
    float JumpForce = 300.0f;
    int key = 0;
    float span = 0.8f;
    float delta = 0;

    void Start()
    {
     this.rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
        this.delta += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if (jp == true)
            {
                Jump();
                jp = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            jp = true;
        }
    }
    void Jump()
    {
        this.rigidbody2D.AddForce(transform.up*this.JumpForce);
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
