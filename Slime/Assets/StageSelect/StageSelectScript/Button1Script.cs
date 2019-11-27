using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button1Script : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("StageEasyScene");
    }
}
