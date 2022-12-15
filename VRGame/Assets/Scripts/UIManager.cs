using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{
    [SerializeField] GameObject deathPanel;
void Start()
    {
       
    }

    private void StartNewGame()
    {
     
    }


    public void ToggleDeathPanel() {
        deathPanel.SetActive(!deathPanel.activeSelf);
    }
}
