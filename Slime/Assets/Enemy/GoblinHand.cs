using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinHand : MonoBehaviour
{
    float a = 1.3f;
    float span = 0.8f;
    float delta = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, a);
        this.delta += Time.deltaTime;
        if (this.delta>this.span)
        {
            this.delta = 0;
            Destroy(gameObject);
        }
    }
}
