using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClearText : MonoBehaviour
{
    public string nextSceneName;
    public void OnClicked()
    {

        UnityEngine.Debug.Log("Button Clicked! Attempting to load scene: " + nextSceneName);
        SceneManager.LoadScene(nextSceneName); // �V�[����J��
        
    }
}
