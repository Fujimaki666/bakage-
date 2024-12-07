using UnityEngine;

public class StopPoint : MonoBehaviour
{
    public UIManager uiManager; // UIマネージャーをリンク

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
