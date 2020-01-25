using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Button2Scripts : MonoBehaviour
{
    public void OnRetry2()
    {
        SceneManager.LoadScene("SecandStage");
    }
    
}
