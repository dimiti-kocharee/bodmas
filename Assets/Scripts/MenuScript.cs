using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour 
{
	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}
}
