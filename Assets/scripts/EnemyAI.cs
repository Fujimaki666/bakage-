using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // プレイヤーの Transform
    public float stopDistance = 1.5f; // 停止距離
    public float alertDistance = 5.0f; // 音楽再生開始の距離
    public string gameover = "GameOver"; // シーン遷移名
     // 再生する音楽
    private bool musicPlayed = false; // 音楽が再生済みかを記録
    private NavMeshAgent agent;
    public AudioSource audioSource;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent を取得
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource を追加
    }

    private void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // 音楽再生距離の判定
        if (distanceToPlayer <= alertDistance && !musicPlayed)
        {
            
            audioSource.Play();
            musicPlayed = true; // 再生済みフラグを立てる
        }

        // プレイヤー追跡および停止距離の判定
        if (distanceToPlayer > stopDistance)
        {
            agent.SetDestination(player.position); // プレイヤーを追跡
        }
        else
        {
            agent.ResetPath(); // 停止
            SceneManager.LoadScene(gameover); // シーン遷移
        }
    }
}
