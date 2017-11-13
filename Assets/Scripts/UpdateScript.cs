using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateScript : MonoBehaviour {
	public Text PresentNumber;
	public Text RandomNumber;



	public static int random_num;
	public float tmp3;


	// Use this for initialization
	void Start () {
		random_num = Random.Range (1, 40);
		RandomNumber.text = random_num.ToString ();
		tmp3 = 1;
		PresentNumber.text =tmp3.ToString() ;


	}



	public void addition()	
	{						
		tmp3 = tmp3 + random_num;

		if (tmp3 <= 0) {					// gameover condition
			TimerandScoreScript.startingTime = -1;

		} 

		random_num = Random.Range (1, 40);
		RandomNumber.text = random_num.ToString ();
		PresentNumber.text = tmp3.ToString() ;
		TimerandScoreScript.startingTime = 10;

		if(tmp3 > 300) {
			TimerandScoreScript.startingTime = -1;

		}


	}

	public void substraction()	
	{
		tmp3 = tmp3 - random_num;


		if (tmp3 <= 0) {					// gameover condition
			TimerandScoreScript.startingTime = -1;

		} else {
			random_num = Random.Range (1, 40);
			RandomNumber.text = random_num.ToString ();
			PresentNumber.text = tmp3.ToString ();
			TimerandScoreScript.startingTime = 10;
			if(tmp3 > 300) {
				TimerandScoreScript.startingTime = -1;

			}

		}


	}

	public void multiplication()	
	{
		tmp3 = tmp3 * random_num;


		if (tmp3 <= 0) {					// gameover condition
			TimerandScoreScript.startingTime = -1;

		} 


		random_num = Random.Range (1, 40);
		RandomNumber.text = random_num.ToString ();
		PresentNumber.text = tmp3.ToString() ;
		TimerandScoreScript.startingTime = 10;
		if(tmp3 > 300) {
			TimerandScoreScript.startingTime = -1;

		}




	}

	public void division()	
	{
		if ((tmp3 % random_num) != 0){        //gameover condition
			TimerandScoreScript.startingTime = -1;
		} else {
			tmp3 = Mathf.Round(tmp3 / random_num);


			if (tmp3 <= 0) {					// gameover condition
				TimerandScoreScript.startingTime = -1;

			} 

			random_num = Random.Range (1, 40);
			RandomNumber.text = random_num.ToString ();
			PresentNumber.text = tmp3.ToString ();
			TimerandScoreScript.startingTime = 10;
			if(tmp3 > 300) {
				TimerandScoreScript.startingTime = -1;

			}


		}
	}

}