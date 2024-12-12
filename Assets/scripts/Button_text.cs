using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Button_text : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    
    public string start = "Start";

    // ボタンが押されたときにシーンをロード
    public void OnClicked()
    {
        SceneManager.LoadScene(start);
    }

    // ボタンが押されたときに text1 を非表示、text2 を表示
    public void OnClicked2()
    {
        text.SetActive(false);
        text1.SetActive(true);
    }
    public void OnClicked3()
    {
        text1.SetActive(false);
        text2.SetActive(true);

    }
    public void OnClicked4()
    {
        text2.SetActive(false);
        text3.SetActive(true);

    }

    // ボタンが押されたときにエンドロールを開始
    public void OnClicked5()
    {
        UnityEngine.Debug.Log("OnClicked3 が呼び出されました");
        text3.SetActive(false);
        text4.SetActive(true);


        StartText starttext = FindObjectOfType<StartText>();

        if (starttext != null)
        {
            UnityEngine.Debug.Log("StartText が見つかりました。エンドロールを開始します");
            starttext.StartEndRoll();
        }
        else
        {
            UnityEngine.Debug.LogError("StartText コンポーネントが見つかりません");
        }
    }

}
