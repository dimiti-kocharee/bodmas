using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerandScoreScript : MonoBehaviour {

	public static float startingTime;

	public  GameObject GameOverPanel;
	public  GameObject GamePlayPanel;

	private Text timeleft;
	void Start () {
		startingTime = 10;
		timeleft = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		startingTime -= Time.deltaTime;

		timeleft.text = " " + Mathf.Round (startingTime);

		if (startingTime < 0) {
			GamePlayPanel.SetActive (false);
			GameOverPanel.SetActive (true);

		}


			
	}
}
