using UnityEngine;
using UnityEngine.SceneManagement; // シーン遷移に必要

public class SceneTransitionTrigger : MonoBehaviour
{
    public string nextSceneName; // 遷移するシーン名

    private void OnTriggerEnter(Collider other)
    {
        // プレイヤーがトリガーに入ったとき
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName); // シーンを遷移
        }
    }
}
