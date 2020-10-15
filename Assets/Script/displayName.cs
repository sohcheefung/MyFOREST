using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class displayName : MonoBehaviour
{
	public Text NameBox;
	
    // Start is called before the first frame update
    void Start()
    {
      NameBox.text = PlayerPrefs.GetString("name");  
    }

    // Update is called once per frame
    public void ResetSavedGame(){
		PlayerPrefs.DeleteKey("name");
		SceneManager.LoadScene("username");
        
    }
	
	public void Menu(){
		SceneManager.LoadScene("Menu");
	}
}
