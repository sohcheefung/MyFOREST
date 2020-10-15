using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
	public static bool boxAppear = false;
	public static bool quitboxAppear = false;
	public GameObject confirmBoxUI;
	public GameObject quitBoxUI;
	
	public GameObject BebusukUI;
	public GameObject KeruingUI;
	public GameObject KundangUI;
	public GameObject MerantiUI;
	public GameObject SintokUI;
	
	public void Quit()
	{
		quitboxAppear = true;
		quitBoxUI.SetActive(true);
		Time.timeScale = 0f;
	}
	
	public void yesQuit()
	{
		Application.Quit();
	}
	
	public void noQuit()
	{
		quitboxAppear = false;
		quitBoxUI.SetActive(false);
		Time.timeScale = 1f;
	}
	
    public void Prev()
	{
		boxAppear = true;
		confirmBoxUI.SetActive(true);
		Time.timeScale = 0f;
		
	}
	
	public void No(){
		boxAppear = false;
		confirmBoxUI.SetActive(false);
		Time.timeScale = 1f;
	}
	
	public void Yes(){
		boxAppear = false;
		confirmBoxUI.SetActive(false);
		SceneManager.LoadScene("Menu");
		Time.timeScale = 1f;
	}
	
	public void loadBebusuk()
	{
		StartCoroutine(Bebusuk());
	}
	
	public void loadKeruing()
	{
		StartCoroutine(Keruing());
	}
	
	public void loadKundang()
	{
		StartCoroutine(Kundang());
	}
	
	public void loadMeranti()
	{
		StartCoroutine(Meranti());
	}
	
	public void loadSintok()
	{
		StartCoroutine(Sintok());
	}
	
	IEnumerator Bebusuk()
	{
		BebusukUI.SetActive(true);
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("Bebusuk");
		BebusukUI.SetActive(false);
	}
	
	IEnumerator Keruing()
	{
		KeruingUI.SetActive(true);
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("Keruing");
		KeruingUI.SetActive(false);
	}
	
	IEnumerator Kundang()
	{
		KundangUI.SetActive(true);
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("Kundang");
		KundangUI.SetActive(false);
	}
	
	IEnumerator Meranti()
	{
		MerantiUI.SetActive(true);
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("Meranti");
		MerantiUI.SetActive(false);
	}
	
	IEnumerator Sintok()
	{
		SintokUI.SetActive(true);
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("Sintok");
		SintokUI.SetActive(false);
	}
}
