﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
	{
		Debug.Log("Level load requested for: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuiteRequest()
	{
		Debug.Log("Quit requested");
		Application.Quit();
	}
}
