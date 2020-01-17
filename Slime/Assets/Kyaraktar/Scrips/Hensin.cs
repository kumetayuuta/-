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

    float span = 20.0f;
    float delta = 0;

    GameObject Star;//変身する時のポイントを取得している

   public StarScripts StarPoint;
    public int kakunin = 0;

    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        this.Star = GameObject.Find("Star");
    }

    void Update()
    {
        if (StarPoint.StarPoint< 5)//２０秒ごとにポイントが自動で増える
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                StarPoint.StarPoint += 1;
                this.Star.GetComponent<Image>().fillAmount += 0.2f;//変身ポイントＵＩの更新
                this.delta = 0;
            }
        }
        if (StarPoint.StarPoint>0)//もしも星があったら変身できる
        {
            if (Input.GetKeyDown(KeyCode.W))//Ｚが押されたら通常スライムになる
            {
                kakunin = 0;
                MainSpriteRenderer.sprite = NomalSprite;//スライムの姿ＵＩの更新
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;//変身ポイントＵＩの更新
                StarPoint.StarPoint += -1;//変身したらポイントが１減る
            }
            if (Input.GetKeyDown(KeyCode.A))//Ａが押されたら炎スライムになる
            {
                kakunin = 2;
                MainSpriteRenderer.sprite = FlamSprite;//スライムの姿ＵＩの更新
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;//変身ポイントＵＩの更新
                StarPoint.StarPoint += -1;//変身したらポイントが１減る
            }
            if (Input.GetKeyDown(KeyCode.S))//Ｓが押されたら水スライムになる
            {
                kakunin = 1;
              MainSpriteRenderer.sprite = WaterSprite;//スライムの姿ＵＩの更新
              this.Star.GetComponent<Image>().fillAmount -= 0.2f;//変身ポイントＵＩの更新
                StarPoint.StarPoint += -1;//変身したらポイントが１減る
            }
            if (Input.GetKeyDown(KeyCode.D))//Ｄが押されたら雷スライムになる
            {
                kakunin = 3;
                MainSpriteRenderer.sprite = ThunderSprite;//スライムの姿ＵＩの更新
                this.Star.GetComponent<Image>().fillAmount -= 0.2f;//変身ポイントＵＩの更新
                StarPoint.StarPoint += -1;//変身したらポイントが１減る
            }
        }
    }
}
