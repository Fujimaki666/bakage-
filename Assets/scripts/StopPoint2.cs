using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPoint2 : MonoBehaviour
{
    public UIManager2 uiManager; // UIマネージャーをリンク

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.Stop(); // プレイヤーを停止
                if (uiManager != null)
                {
                    uiManager.ShowSelectionPanel(); // 選択UIを表示
                }
            }
        }
    }
}
