using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHit : MonoBehaviour
{
    public GameObject enemy;
    public GoblinHp GoburinHp;
    public AudioClip Hit;
    Animator animator;
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.animator.SetTrigger("NoAnimaTrigger");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerAtk")
        {
            GetComponent<AudioSource>().PlayOneShot(Hit);
            GoburinHp.GoburinHp += -1;
            transform.Translate(-0.1f,0, 0);
            this.animator.SetTrigger("MoveTrigger");
        }
    }
}
