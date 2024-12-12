using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // ボタンにアクセスするために追加

public class StartText : MonoBehaviour
{
    [SerializeField]
    private float textScrollSpeed = 30f; // テキストのスクロール速度
    [SerializeField]
    private float limitPosition = 730f; // エンドロールの終了位置
    private bool isStopEndRoll = true; // エンドロール停止フラグ（初期値は停止）

    public GameObject text1; // エンドロール開始時に表示するオブジェクト
    public GameObject text2; // エンドロール開始時に非表示にするオブジェクト

    void Update()
    {
        // エンドロールが停止している場合、何もしない
        if (isStopEndRoll)
        {
            return;
        }

        // エンドロールを上方向にスクロール
        if (transform.position.y <= limitPosition)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime);
        }
        else
        {
            // エンドロールが終了したら停止し、次のシーンに遷移
            isStopEndRoll = true;
            StartCoroutine(GoToNextScene());
        }
    }

    // エンドロールを開始するメソッド
    public void StartEndRoll()
    {
        isStopEndRoll = false; // 停止フラグを解除
        transform.position = new Vector2(transform.position.x, 0); // テキスト位置を初期化
       
    }

    // エンドロール終了後に次のシーンに遷移
    IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Game");
    }
}
