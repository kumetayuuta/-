using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHit : MonoBehaviour
{
    public GameObject enemy;
    public GoblinHp GoburinHp;
    public AudioClip Hit;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerAtk")
        {
            GetComponent<AudioSource>().PlayOneShot(Hit);
            GoburinHp.GoburinHp += -1;
        }
    }
}
