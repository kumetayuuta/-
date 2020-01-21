using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Button1Script : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene("StageEasyScene");
    }
}
