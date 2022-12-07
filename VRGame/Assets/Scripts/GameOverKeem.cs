using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverKeem : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Setup(){
        gameObject.SetActive(true);
    }
    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Menu()
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void Continue()
    {
        Debug.Log("Continue");
        SceneManager.LoadScene("Kenneth");
    }
}
