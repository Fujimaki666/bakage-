using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartText : MonoBehaviour
{
    // �e�L�X�g�̃X�N���[���X�s�[�h
    [SerializeField]
    private float textScrollSpeed = 30f;
    // �e�L�X�g�̐����ʒu
    [SerializeField]
    private float limitPosition = 730f;
    // �G���h���[�����I���������ǂ���
    private bool isStopEndRoll;

    void Update()
    {
        // �G���h���[�����I��������
        if (isStopEndRoll)
        {
            return; // �������Ȃ��i�G���h���[���I����͎����J�ڑҋ@���j
        }

        // �G���h���[���p�e�L�X�g�����~�b�g���z����܂œ�����
        if (transform.position.y <= limitPosition)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime);
        }
        else
        {
            // �G���h���[���I���t���O�𗧂Ă�
            isStopEndRoll = true;
            // ��莞�Ԍ�ɃV�[���J�ڂ��J�n
            StartCoroutine(GoToNextScene());
        }
    }

    IEnumerator GoToNextScene()
    {
        // 5�b�ԑ҂�
        yield return new WaitForSeconds(0.5f);

        // �V�[���������I�ɑJ��
        SceneManager.LoadScene("Game");
    }
}
