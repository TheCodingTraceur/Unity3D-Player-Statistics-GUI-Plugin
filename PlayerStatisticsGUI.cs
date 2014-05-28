/*
 * Copyright 2014 TheCodingTraceur.  All rights reserved.
 */

using UnityEngine;
using System;

[Serializable]
public class PlayerStatisticsGUI : MonoBehaviour {

	public bool show;  //Show player stats?
	
	public bool showFOV;  //Show FOV?

	public bool showPosition;  //Show position?

	public GameObject character;  //Character

	public Camera characterCamera; //Character

	void OnGUI () {

		float characterCameraFOV = characterCamera.fieldOfView;  //FOV
		
		Transform characterTransfrom = character.transform;  //Position

		//Show player stats?
		if (show == true) {

			GUI.TextArea(new Rect(10, 10, 100, 20), "Player stats:");  //Add "Player Stats:" heading 

			//Modify positioning of stat menu items
			switch (showFOV) {
			
			case true:

				GUI.TextArea(new Rect(50, 40, 65, 20), "FOV:" + characterCameraFOV);

				if (showPosition == true) {
					GUI.TextArea(new Rect(50, 70, 200, 20), "Coordinates: " + characterTransfrom.position);
				}
				break;
			
			case false:

				if (showPosition == true) {
					GUI.TextArea(new Rect(50, 40, 200, 20), "Coordinates: " + characterTransfrom.position);
				}
				break;
			}
		}
	}
}