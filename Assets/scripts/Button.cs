using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {



	public void Test () 
	{
		Debug.LogError ("Button was pressed");
		Application.LoadLevel ("MapScene");
	}
}
