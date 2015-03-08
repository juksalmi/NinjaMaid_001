using UnityEngine;
using System.Collections;

public class touchTest : MonoBehaviour {
	string text = "test";
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		#if UNITY_EDITOR
		Debug.Log("Unity Editor");
		if(Input.GetMouseButtonDown(0))
			text = Input.mousePosition.ToString();
		#endif
		if(Input.touchCount==1)
		{

			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Vector2 startPos = Input.GetTouch(0).position;
			}
			if(Input.GetTouch(0).phase == TouchPhase.Moved)
			{

			}
			
		}
		#if UNITY_IPHONE
		Debug.Log("Iphone");


		#endif
		
		#if UNITY_STANDALONE_OSX
		Debug.Log("Stand Alone OSX");
		#endif
		
		#if UNITY_STANDALONE_WIN
		Debug.Log("Stand Alone Windows");
		if(Input.GetMouseButtonDown(0))
			text = Input.mousePosition.ToString();
		#endif    
	}
	void OnGUI()
	{
		GUI.Label (new Rect (100, 100, 300, 30), text);
	}
}
