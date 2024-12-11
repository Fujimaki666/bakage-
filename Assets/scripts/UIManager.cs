using System.Diagnostics;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    
    public GameObject selectionPanel;
    private void Start() {
        selectionPanel.SetActive(false);
        UnityEngine.Debug.Log("Selection panel initialized and set to inactive."); 
    }
    public void ShowSelectionPanel() { 
        selectionPanel.SetActive(true);
        UnityEngine.Debug.Log($"Selection panel active: {selectionPanel.activeSelf}, Name: {selectionPanel.name}"); 
    }
    public void HideSelectionPanel() { selectionPanel.SetActive(false); }
    public void OnLeftButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveLeft();

        } 
        HideSelectionPanel(); 
    }
    public void OnRightButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveRight();
        }
        HideSelectionPanel(); 
    }
    public void OnGoButtonClicked()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.MoveGo();
        }
        HideSelectionPanel();
    }
}
