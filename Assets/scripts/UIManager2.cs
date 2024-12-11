using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager2 : MonoBehaviour
{
    public GameObject selectionPanel;
    public GameObject yuka;
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
    public void HideSelectionPanel() { selectionPanel.SetActive(false); }
    public void OnLeftButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            //player.MoveLeft_Door();
            yuka.SetActive(false);

        }
        HideSelectionPanel();
    }
    public void OnRightButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            //player.MoveRight_Door();
            yuka.SetActive(false);
        }
        HideSelectionPanel();
    }
    public void OnGoButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveGo_Door();
        }
        HideSelectionPanel();
    }
}
