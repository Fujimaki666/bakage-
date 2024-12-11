using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UIManager5 : MonoBehaviour
{
    public GameObject selectionPanel;
    public int[] correctOrder = { 1, 2, 3, 4, 5, 6 }; // ����������
    private int currentStep = 0; // ���݂̃X�e�b�v

    // �h�A�I�u�W�F�N�g
    public GameObject door;
    [SerializeField]
    private Animator automaticDoorAnimator5;

    private void Start()
    {
        selectionPanel.SetActive(false);
        UnityEngine.Debug.Log("Selection panel initialized and set to inactive.");
    }

    public void ShowSelectionPanel()
    {
        selectionPanel.SetActive(true);
        UnityEngine.Debug.Log($"Selection panel active: {selectionPanel.activeSelf}, Name: {selectionPanel.name}");
    }

    public void HideSelectionPanel()
    {
        selectionPanel.SetActive(false);
    }

    public void OnButtonPressed(int buttonId)
    {
        PlayerController player = FindObjectOfType<PlayerController>();

        // �����ꂽ�{�^�����������������m�F
        if (buttonId == correctOrder[currentStep])
        {
            currentStep++; // �����̏ꍇ�A���̃X�e�b�v�֐i��
            UnityEngine.Debug.Log($"�{�^�� {buttonId} �͐������ł��I���݂̃X�e�b�v: {currentStep}");

            if (currentStep >= correctOrder.Length)
            {
                // �S�Đ���������h�A���J��
                OpenDoor();
                HideSelectionPanel();
                player.MoveGo_last();
            }
        }
        else
        {
            UnityEngine.Debug.Log($"�{�^�� {buttonId} �͊Ԉ���Ă��܂��I���Z�b�g���܂��B");
            ResetSequence(); // �ԈႦ���ꍇ���Z�b�g
        }
    }

    private void OpenDoor()
    {
        UnityEngine.Debug.Log("�h�A���J���܂����I");
        if (door != null)
        {
            // �h�A���J���鏈���i��: �A�j���[�V�������Đ�����j
            automaticDoorAnimator5.SetBool("Open3", true);
        }
    }

    private void ResetSequence()
    {
        UnityEngine.Debug.Log("�V�[�P���X�����Z�b�g���܂��B");
        currentStep = 0; // �X�e�b�v�����Z�b�g
    }
}
