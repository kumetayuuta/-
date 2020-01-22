using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoburinMove : MonoBehaviour
{
   
    float speed = 0.0f;
    public bool AtkOK=false;
    GameObject player;
    Animator animator;
    void Start()
    {
        this.player = GameObject.Find("スライム");
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, this.player.transform.position);//距離を求める
        if (distance < 5f&& distance > 2.5f)
        {
             AtkOK = false;    
             speed = 2.0f;
            this.animator.SetTrigger("MoveTrigger");
            if (transform.position.x > this.player.transform.position.x)
            {
                transform.Translate(-this.speed * Time.deltaTime, 0, 0);
            }
            else if (transform.position.x < this.player.transform.position.x)
            {
                transform.Translate(this.speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            this.animator.SetTrigger("NoAnimaTrigger");
        }
        if (distance <2.5f)
        {
            AtkOK = true;
        }
    }
}
