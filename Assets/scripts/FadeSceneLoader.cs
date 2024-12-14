using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeSceneLoader : MonoBehaviour
{
    public Image fadePanel;             // �t�F�[�h�p��UI�p�l���iImage�j
    public float fadeDuration = 1.0f;   // �t�F�[�h�̊����ɂ����鎞��
    public AudioSource audioSource;     // ���y�p��AudioSource
    public float waitTime = 60.0f;      // �t�F�[�h�A�E�g�O�̑ҋ@���ԁi�b�j
    public float audioStartTime = 55.0f;
    private void Start()
    {
        audioSource.time = audioStartTime; 
        audioSource.Play();
        StartCoroutine(WaitAndFadeOut());
    }

    private IEnumerator WaitAndFadeOut()
    {
        yield return new WaitForSeconds(waitTime); // �w�莞�ԑҋ@
        yield return StartCoroutine(FadeOutMusicAndScene()); // ���y�ƃt�F�[�h�A�E�g
    }

    private IEnumerator FadeOutMusicAndScene()
    {
        fadePanel.enabled = true;                 // �p�l����L����
        float elapsedTime = 0.0f;                 // �o�ߎ��Ԃ�������
        Color startColor = fadePanel.color;       // �t�F�[�h�p�l���̊J�n�F���擾
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f); // �t�F�[�h�p�l���̍ŏI�F��ݒ�
        float startVolume = audioSource.volume;   // ���ʂ̏����l���擾

        // �t�F�[�h�A�E�g�A�j���[�V���������s
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // �o�ߎ��Ԃ𑝂₷
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);  // �t�F�[�h�̐i�s�x���v�Z

            // �t�F�[�h�A�E�g: �F�Ɖ��ʂ𓯎��ɕω�������
            fadePanel.color = Color.Lerp(startColor, endColor, t); 
            audioSource.volume = Mathf.Lerp(startVolume, 0.0f, t); // ���ʂ����X�ɉ�����

            yield return null; // 1�t���[���ҋ@
        }

        // �t�F�[�h�A�E�g�I����̍ŏI��Ԃ�ݒ�
        fadePanel.color = endColor; // �p�l�����ŏI�F�ɐݒ�
        audioSource.volume = 0.0f;  // ���ʂ��[���ɐݒ�

        SceneManager.LoadScene("GameOver_fall"); // �V�[�������[�h���ă��j���[�V�[���ɑJ��
    }
}
