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

    GameObject Star;
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        this.Star = GameObject.Find("Star");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))//Ｚが押されたら通常スライムになる
        {
            if (this.Star.GetComponent<Image>().fillAmount != 0.1)//もしも星があったら変身できる
            {
                Nomal();
                MainSpriteRenderer.sprite = NomalSprite;
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))//Ａが押されたら炎スライムになる
        {
            if (this.Star.GetComponent<Image>().fillAmount != 0.1)//もしも星があったら変身できる
            {
                Flam();
                MainSpriteRenderer.sprite = FlamSprite;
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))//Ｓが押されたら水スライムになる
        {
            if (this.Star.GetComponent<Image>().fillAmount != 0.1)//もしも星があったら変身できる
            {
                water();
                MainSpriteRenderer.sprite = WaterSprite;
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))//Ｄが押されたら雷スライムになる
        {
            if (this.Star.GetComponent<Image>().fillAmount != 0.1)//もしも星があったら変身できる
            {
                Thunder();
                MainSpriteRenderer.sprite = ThunderSprite;
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            }
        }
    }
    void Nomal()
    {
        if (Input.GetKeyDown(KeyCode.C))//Cを押したら
        {

        }
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
