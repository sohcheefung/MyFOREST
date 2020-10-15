using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class username : MonoBehaviour
{
	public InputField textBox;
	string tutorialText;

	void Start()
	{
		tutorialText = PlayerPrefs.GetString("name");
		textBox.text = tutorialText;

		//inputText = GameObject.Find ("tutorialTextKeyName").GetComponent<InputField> ();
	}

	public void clickSaveButton(){
		PlayerPrefs.SetString("name", textBox.text);
		//Debug.Log("Welcome " + PlayerPrefs.GetString("name"));
		SceneManager.LoadScene("displayUsername");
		
	}

	public void SaveThis()
	{
		tutorialText = textBox.text;
		PlayerPrefs.SetString("name", tutorialText);
	}

	public void Profile()
    {
		SceneManager.LoadScene("displayUsername");
    }
}
