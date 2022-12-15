using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMana : MonoBehaviour{
    public static levelMana instance;
    private void Awake(){
        if(levelMana.instance== null) instance = this;
        else Destroy(gameObject);
    
}
 public void GameOver(){
    UIManager _ui= GetComponent<UIManager>();
    if(_ui !=null){
        _ui.ToggleDeathPanel();
    }
 }



}