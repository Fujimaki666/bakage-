using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPoint5 : MonoBehaviour
{
    public UIManager5 uiManager; // UI�}�l�[�W���[�������N

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
