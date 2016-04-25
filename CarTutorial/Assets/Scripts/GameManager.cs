using UnityEngine;
using System.Collections;
using System; 

public class GameManager : MonoBehaviour {

	private int time; //your time in seconds

	// Use this for initialization
	void Start () {
	
	}

	void medalPicker() {
		return;
	}

	//returns your time in a proper mm:ss format
	String timeConverter(int seconds) {
		if (seconds <= 60)
			return "" + seconds;
		else
			return seconds / 60 + ":" + seconds % 60;

		}
}
