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

   public StarScripts StarPoint;


    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        this.Star = GameObject.Find("Star");
    }

    void Update()
    {
        if (StarPoint.StarPoint<1.9)//もしも星があったら変身できる
        {
            if (Input.GetKeyDown(KeyCode.Z))//Ｚが押されたら通常スライムになる
            {
            Nomal();
            MainSpriteRenderer.sprite = NomalSprite;
            this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            
            }
            if (Input.GetKeyDown(KeyCode.A))//Ａが押されたら炎スライムになる
            {          
             Flam();
             MainSpriteRenderer.sprite = FlamSprite;
             this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            }
            if (Input.GetKeyDown(KeyCode.S))//Ｓが押されたら水スライムになる
            {           
             water();
             MainSpriteRenderer.sprite = WaterSprite;
             this.Star.GetComponent<Image>().fillAmount -= 0.2f;
            }
            if (Input.GetKeyDown(KeyCode.D))//Ｄが押されたら雷スライムになる
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
