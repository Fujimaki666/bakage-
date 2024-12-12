using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // �{�^���ɃA�N�Z�X���邽�߂ɒǉ�

public class StartText : MonoBehaviour
{
    [SerializeField]
    private float textScrollSpeed = 30f; // �e�L�X�g�̃X�N���[�����x
    [SerializeField]
    private float limitPosition = 730f; // �G���h���[���̏I���ʒu
    private bool isStopEndRoll = true; // �G���h���[����~�t���O�i�����l�͒�~�j

    public GameObject text1; // �G���h���[���J�n���ɕ\������I�u�W�F�N�g
    public GameObject text2; // �G���h���[���J�n���ɔ�\���ɂ���I�u�W�F�N�g

    void Update()
    {
        // �G���h���[������~���Ă���ꍇ�A�������Ȃ�
        if (isStopEndRoll)
        {
            return;
        }

        // �G���h���[����������ɃX�N���[��
        if (transform.position.y <= limitPosition)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime);
        }
        else
        {
            // �G���h���[�����I���������~���A���̃V�[���ɑJ��
            isStopEndRoll = true;
            StartCoroutine(GoToNextScene());
        }
    }

    // �G���h���[�����J�n���郁�\�b�h
    public void StartEndRoll()
    {
        isStopEndRoll = false; // ��~�t���O������
        transform.position = new Vector2(transform.position.x, 0); // �e�L�X�g�ʒu��������
       
    }

    // �G���h���[���I����Ɏ��̃V�[���ɑJ��
    IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Game");
    }
}
