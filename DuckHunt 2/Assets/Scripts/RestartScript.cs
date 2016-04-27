using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour 
{
	public Canvas restartMenu;
	public Button restartText; 
	public Button quitText;

	void Start () 
	{
		restartMenu = restartMenu.GetComponent<Canvas> ();
		restartText = restartText.GetComponent<Button> ();
		quitText = quitText.GetComponent<Button> ();
		restartMenu.enabled = false;
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene (1);
	}

	public void QuitGame()
	{
		SceneManager.LoadScene (0);
	}


	//public void PlayerDies()
	//{
		//restartMenu.enabled = true;
		//restartText.enabled = false;
		//quitText.enabled = false;
	//}
}
