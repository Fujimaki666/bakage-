using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // �v���C���[�� Transform
    public float stopDistance = 1.5f; // ��~����
    public float alertDistance = 5.0f; // ���y�Đ��J�n�̋���
    public string gameover = "GameOver"; // �V�[���J�ږ�
     // �Đ����鉹�y
    private bool musicPlayed = false; // ���y���Đ��ς݂����L�^
    private NavMeshAgent agent;
    public AudioSource audioSource;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent ���擾
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource ��ǉ�
    }

    private void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // ���y�Đ������̔���
        if (distanceToPlayer <= alertDistance && !musicPlayed)
        {
            
            audioSource.Play();
            musicPlayed = true; // �Đ��ς݃t���O�𗧂Ă�
        }

        // �v���C���[�ǐՂ���ђ�~�����̔���
        if (distanceToPlayer > stopDistance)
        {
            agent.SetDestination(player.position); // �v���C���[��ǐ�
        }
        else
        {
            agent.ResetPath(); // ��~
            SceneManager.LoadScene(gameover); // �V�[���J��
        }
    }
}
