using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    public string start = "Start";
    // Start is called before the first frame update
    public void OnClicked()
    {
        SceneManager.LoadScene(start);
    }
}
