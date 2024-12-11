using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class retry : MonoBehaviour
{
    public string Retry = "Game";
    // Start is called before the first frame update
    public void OnClicked()
    {
        SceneManager.LoadScene(Retry);
    }
}
