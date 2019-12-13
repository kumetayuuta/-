using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atk2Scripts : MonoBehaviour
{
    float span = 0.3f;
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            Destroy(gameObject);
        }
    }
}
