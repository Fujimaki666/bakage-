using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshProを使用する場合

public class CountdownManager : MonoBehaviour
{
    public TextMeshProUGUI countdownText; // カウントダウン用のText (TMP)
    public float countdownTime = 3f; // カウントダウンの開始値
    public GameObject panel;
    public GameObject stop;
    private void Start()
    {
        if (countdownText == null)
        {
            //Debug.LogError("Countdown Text is not assigned in the inspector.");
            return;
        }
        StartCoroutine(CountdownCoroutine());
    }

    private IEnumerator CountdownCoroutine()
    {
        float remainingTime = countdownTime;

        while (remainingTime > 0)
        {
            countdownText.text = Mathf.CeilToInt(remainingTime).ToString(); // 整数に変換して表示
            yield return new WaitForSeconds(1f); // 1秒待つ
            remainingTime--;
        }

        countdownText.text = "GO!"; // 最後に「GO!」を表示
        yield return new WaitForSeconds(1f); // 1秒表示
        countdownText.text = ""; // カウントダウンテキストを消す
        panel.SetActive(false);
        stop.SetActive(false);
    }
}
