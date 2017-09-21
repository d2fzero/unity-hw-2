using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenescripts : MonoBehaviour {
	public string nextScene;

	public void ChangeScene ()
	{
		SceneManager.LoadScene (nextScene);
	}
		
	}

