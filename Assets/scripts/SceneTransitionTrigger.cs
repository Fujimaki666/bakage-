using UnityEngine;
using UnityEngine.SceneManagement; // �V�[���J�ڂɕK�v

public class SceneTransitionTrigger : MonoBehaviour
{
    public string nextSceneName; // �J�ڂ���V�[����

    private void OnTriggerEnter(Collider other)
    {
        // �v���C���[���g���K�[�ɓ������Ƃ�
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName); // �V�[����J��
        }
    }
}
