using UnityEngine;
using System.Collections;

public class TogglePanelScript : MonoBehaviour {

	public void TogglePanel (GameObject panel) {
		panel.SetActive (!panel.activeSelf);
	}
}