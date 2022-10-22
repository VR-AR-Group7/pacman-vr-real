using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject _mainMenu;
    [SerializeField] GameObject _selectLevelMenu;

    // Start is called before the first frame update
    void Start()
    {
        _selectLevelMenu.SetActive(false);
    }

    public void DisableMenu()
    {
        // Debug.Log(_mainMenu.activeSelf);
        _mainMenu.SetActive(false);
        _selectLevelMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
