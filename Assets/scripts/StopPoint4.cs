using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPoint4 : MonoBehaviour
{
    public UIManager4 uiManager; // UI�}�l�[�W���[�������N

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