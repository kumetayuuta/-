using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atk1Scripts : MonoBehaviour
{
    float span = 1.0f;
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0.1f * transform.localScale.x, 0, 0);
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }    
}
