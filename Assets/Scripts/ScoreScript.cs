using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static Text scorex;
	public float scoreInit;
	private Text score;


	// Use this for initialization
	void Start () {
		scoreInit = 0;
		score = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreInit += Time.deltaTime*8;

		if (TimerandScoreScript.startingTime > 0) {
			score.text = " " + Mathf.Round (scoreInit);
		} else {
			scorex.text = score.text;
		}
	}
}
