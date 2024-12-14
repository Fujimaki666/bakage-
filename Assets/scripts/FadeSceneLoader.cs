using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeSceneLoader : MonoBehaviour
{
    public Image fadePanel;             // フェード用のUIパネル（Image）
    public float fadeDuration = 1.0f;   // フェードの完了にかかる時間
    public AudioSource audioSource;     // 音楽用のAudioSource
    public float waitTime = 60.0f;      // フェードアウト前の待機時間（秒）
    public float audioStartTime = 55.0f;
    private void Start()
    {
        audioSource.time = audioStartTime; 
        audioSource.Play();
        StartCoroutine(WaitAndFadeOut());
    }

    private IEnumerator WaitAndFadeOut()
    {
        yield return new WaitForSeconds(waitTime); // 指定時間待機
        yield return StartCoroutine(FadeOutMusicAndScene()); // 音楽とフェードアウト
    }

    private IEnumerator FadeOutMusicAndScene()
    {
        fadePanel.enabled = true;                 // パネルを有効化
        float elapsedTime = 0.0f;                 // 経過時間を初期化
        Color startColor = fadePanel.color;       // フェードパネルの開始色を取得
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); // フェードパネルの最終色を設定
        float startVolume = audioSource.volume;   // 音量の初期値を取得

        // フェードアウトアニメーションを実行
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // 経過時間を増やす
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  // フェードの進行度を計算

            // フェードアウト: 色と音量を同時に変化させる
            fadePanel.color = Color.Lerp(startColor, endColor, t); 
            audioSource.volume = Mathf.Lerp(startVolume, 0.0f, t); // 音量を徐々に下げる

            yield return null; // 1フレーム待機
        }

        // フェードアウト終了後の最終状態を設定
        fadePanel.color = endColor; // パネルを最終色に設定
        audioSource.volume = 0.0f;  // 音量をゼロに設定

        SceneManager.LoadScene("GameOver_fall"); // シーンをロードしてメニューシーンに遷移
    }
}
