using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshPro���g�p����ꍇ

public class CountdownManager : MonoBehaviour
{
    public TextMeshProUGUI countdownText; // �J�E���g�_�E���p��Text (TMP)
    public float countdownTime = 3f; // �J�E���g�_�E���̊J�n�l
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
            countdownText.text = Mathf.CeilToInt(remainingTime).ToString(); // �����ɕϊ����ĕ\��
            yield return new WaitForSeconds(1f); // 1�b�҂�
            remainingTime--;
        }

        countdownText.text = "GO!"; // �Ō�ɁuGO!�v��\��
        yield return new WaitForSeconds(1f); // 1�b�\��
        countdownText.text = ""; // �J�E���g�_�E���e�L�X�g������
        panel.SetActive(false);
        stop.SetActive(false);
    }
}
