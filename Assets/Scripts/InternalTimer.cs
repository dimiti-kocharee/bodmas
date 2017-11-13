using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class InternalTimer : MonoBehaviour {


	public static Text upperlimit;
	public static float multiplier;

	public static float timer;
	//private Text timer_rounded;
	// Use this for initialization
	void Start () {
		timer = 0;
		//timer_rounded = GetComponent<Text> ();

		upperlimit.text = " " + 100;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		//timer_rounded.text = " " + Mathf.Round (timer);
		multiplier = timer / 100;
		upperlimit.text = " " + (100 * (Mathf.Round (multiplier))).ToString();
	}
}
