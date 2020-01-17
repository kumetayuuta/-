using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    GameObject Hp;
    int PlaterHp = 10;
    void Start()
    {
        this.Hp = GameObject.Find("Hp");
    }

    void Update()
    {
        if (PlaterHp<=0)
        {
            SceneManager.LoadScene("GameOverScene");
        }  
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EnemyAtk")
        {
            this.Hp.GetComponent<Image>().fillAmount -= 0.1f;
            PlaterHp -= 1;
        }
    }
}
