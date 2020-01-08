using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobrinKoujou : MonoBehaviour
{
    public GameObject GobrinObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = Instantiate(GobrinObject) as GameObject;
    }
}
