using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {

	public void ClickTest(string areaName)
	{
		Debug.Log (areaName);
		Application.LoadLevel("StarScene");
	}

	public void ClickBack()
	{
		Application.LoadLevel("MapScene");
	}

	public void ClickQuit()
	{
		Application.Quit();
	}

	public void StartGame()
	{
		Application.LoadLevel("LevelScene1");
	}

}
