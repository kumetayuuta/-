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

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.1f,0,0);
        this.delta += Time.deltaTime;
        if (this.delta>this.span)
        {
            Destroy(gameObject);
        }
    }
}
