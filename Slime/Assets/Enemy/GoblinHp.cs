using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinHp : MonoBehaviour
{
    [SerializeField]
    public int GoburinHp = 1;
    public GameObject Enemy;
    void Start()
    {
        
    }

    void Update()
    {
        if (GoburinHp<=0)
        {
            Destroy(Enemy);
        }
    }
}
