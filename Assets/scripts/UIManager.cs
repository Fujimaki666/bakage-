using System.Diagnostics;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject selectionPanel; // ボタンを含むUIパネル

    private void Start()
    {
        selectionPanel.SetActive(false); // 初期状態で非表示
    }

    // 選択UIを表示
    public void ShowSelectionPanel()
    {
        selectionPanel.SetActive(true);
        UnityEngine.Debug.Log($"Selection panel active: {selectionPanel.activeSelf}, Name: {selectionPanel.name}");
        UnityEngine.Debug.Log($"Selection panel position: {selectionPanel.transform.position}");
    }

    // 選択UIを非表示
    public void HideSelectionPanel()
    {
        selectionPanel.SetActive(false);
    }

    // 左ボタンが押されたとき
    public void OnLeftButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveLeft(); // プレイヤーを左に移動
        }
        HideSelectionPanel();
    }

    // 右ボタンが押されたとき
    public void OnRightButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveRight(); // プレイヤーを右に移動
        }
        HideSelectionPanel();
    }
}
