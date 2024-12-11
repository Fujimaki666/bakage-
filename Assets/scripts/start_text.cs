using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartText : MonoBehaviour
{
    // テキストのスクロールスピード
    [SerializeField]
    private float textScrollSpeed = 30f;
    // テキストの制限位置
    [SerializeField]
    private float limitPosition = 730f;
    // エンドロールが終了したかどうか
    private bool isStopEndRoll;

    void Update()
    {
        // エンドロールが終了した時
        if (isStopEndRoll)
        {
            return; // 何もしない（エンドロール終了後は自動遷移待機中）
        }

        // エンドロール用テキストがリミットを越えるまで動かす
        if (transform.position.y <= limitPosition)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime);
        }
        else
        {
            // エンドロール終了フラグを立てる
            isStopEndRoll = true;
            // 一定時間後にシーン遷移を開始
            StartCoroutine(GoToNextScene());
        }
    }

    IEnumerator GoToNextScene()
    {
        // 5秒間待つ
        yield return new WaitForSeconds(0.5f);

        // シーンを自動的に遷移
        SceneManager.LoadScene("Game");
    }
}
