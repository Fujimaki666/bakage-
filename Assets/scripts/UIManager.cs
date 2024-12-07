using System.Diagnostics;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject selectionPanel; // �{�^�����܂�UI�p�l��

    private void Start()
    {
        selectionPanel.SetActive(false); // ������ԂŔ�\��
    }

    // �I��UI��\��
    public void ShowSelectionPanel()
    {
        selectionPanel.SetActive(true);
        UnityEngine.Debug.Log($"Selection panel active: {selectionPanel.activeSelf}, Name: {selectionPanel.name}");
        UnityEngine.Debug.Log($"Selection panel position: {selectionPanel.transform.position}");
    }

    // �I��UI���\��
    public void HideSelectionPanel()
    {
        selectionPanel.SetActive(false);
    }

    // ���{�^���������ꂽ�Ƃ�
    public void OnLeftButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveLeft(); // �v���C���[�����Ɉړ�
        }
        HideSelectionPanel();
    }

    // �E�{�^���������ꂽ�Ƃ�
    public void OnRightButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveRight(); // �v���C���[���E�Ɉړ�
        }
        HideSelectionPanel();
    }
}
