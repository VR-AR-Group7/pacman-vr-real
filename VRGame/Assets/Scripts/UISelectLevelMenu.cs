using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISelectLevelMenu : MonoBehaviour
{
    [SerializeField] GameObject _mainMenu;
    [SerializeField] GameObject _selectLevelMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackMainMenu()
    {
        _selectLevelMenu.SetActive(false);
        _mainMenu.SetActive(true); 
    }

    public void GetFirstLevel()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Keem);
    }

    public void GetSecondLevel()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Thomas);
    }

    public void GetThirdLevel()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Kenneth);
    }

    public void GetFourthLevel()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Carlos);
    }
}
