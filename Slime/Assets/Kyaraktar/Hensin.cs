using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hensin : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite NomalSprite;
    public Sprite FlamSprite;
    public Sprite WaterSprite;
    public Sprite ThunderSprite;

    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))//Ｚが押されたら通常スライムになる
        {
            Nomal();
            MainSpriteRenderer.sprite = NomalSprite;
        }
        if (Input.GetKeyDown(KeyCode.A))//Ａが押されたら炎スライムになる
        {
            Flam();
            MainSpriteRenderer.sprite = FlamSprite;
        }
        if (Input.GetKeyDown(KeyCode.S))//Ｓが押されたら水スライムになる
        {
            water();
            MainSpriteRenderer.sprite = WaterSprite;
        }
        if (Input.GetKeyDown(KeyCode.D))//Ｄが押されたら雷スライムになる
        {
            Thunder();
            MainSpriteRenderer.sprite = ThunderSprite;
        }
    }
    void Nomal()
    {

    }
    void Flam()
    {

    }
    void water()
    {

    }
    void Thunder()
    {

    }
}
