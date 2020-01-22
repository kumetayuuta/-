using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobrinKoujou : MonoBehaviour
{
    public GameObject GobrinObject;
    public GoburinMove AtkOK;
    float span = 1.0f;
    float delta = 0;
    public GameObject Gobrin;
    void Start()
    {
        
    }

   
    void Update()
    {
          this.delta += Time.deltaTime;
          float px = transform.position.x;
          float py = transform.position.y+0.3f;
        if (this.delta > this.span)
        {
            this.delta = 0;
            if (AtkOK.AtkOK == true)
            {
                GameObject go = Instantiate(GobrinObject) as GameObject;
                go.transform.position = new Vector3(px, py, 0);
            }
        }
    }
}
