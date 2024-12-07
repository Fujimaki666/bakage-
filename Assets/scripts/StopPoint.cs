using UnityEngine;

public class StopPoint : MonoBehaviour
{
    public UIManager uiManager; // UI�}�l�[�W���[�������N

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.Stop(); // �v���C���[���~
                if (uiManager != null)
                {
                    uiManager.ShowSelectionPanel(); // �I��UI��\��
                }
            }
        }
    }
}
