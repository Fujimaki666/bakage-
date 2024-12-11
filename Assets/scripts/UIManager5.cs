using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UIManager5 : MonoBehaviour
{
    public GameObject selectionPanel;
    public int[] correctOrder = { 1, 2, 3, 4, 5, 6 }; // 正しい順序
    private int currentStep = 0; // 現在のステップ

    // ドアオブジェクト
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

        // 押されたボタンが正しい順序か確認
        if (buttonId == correctOrder[currentStep])
        {
            currentStep++; // 正解の場合、次のステップへ進む
            UnityEngine.Debug.Log($"ボタン {buttonId} は正しいです！現在のステップ: {currentStep}");

            if (currentStep >= correctOrder.Length)
            {
                // 全て正解したらドアを開く
                OpenDoor();
                HideSelectionPanel();
                player.MoveGo_last();
            }
        }
        else
        {
            UnityEngine.Debug.Log($"ボタン {buttonId} は間違っています！リセットします。");
            ResetSequence(); // 間違えた場合リセット
        }
    }

    private void OpenDoor()
    {
        UnityEngine.Debug.Log("ドアが開きました！");
        if (door != null)
        {
            // ドアを開ける処理（例: アニメーションを再生する）
            automaticDoorAnimator5.SetBool("Open3", true);
        }
    }

    private void ResetSequence()
    {
        UnityEngine.Debug.Log("シーケンスをリセットします。");
        currentStep = 0; // ステップをリセット
    }
}
