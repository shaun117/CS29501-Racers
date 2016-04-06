/*using UnityEngine;
using System.Collections;

[ExecuteInEditMode()]

public class WayPointController : MonoBehaviour {

	private ArrayList transforms; //easily access waypoint transforms
	private Vector3 firstPoint;   //store our first waypoint here so we can loop around a path
	private float distance; 	  //used to calc distance between waypoints
	private Transform tempTrans;  //temp holder for transform
	private int tempIndex; 		  //temp holder for a waypoint index
	private int totalTransforms;  //total amount of waypoints/transforms
	private Vector3 currentPos;   //Current position of the waypoint
	private Vector3 lastPos; 	  //last waypoint position car was at

	// Use this for initialization
	void Start () {

		//make sure we grab all the transforms for each waypoint on start
		//GetTransforms ();
	}
	
	void OnDrawGizmos() {

		//if we dont have any transforms for waypoints, then grab them all
		if (transforms == null)
			//GetTransforms ();

		//make sure that we have more than one transform in our list, otherwise we cant draw lines between them
		if (transforms.Count < 2)
			return; 

		//draw our path around the track, first grab the position of our first waypoint
		//so the line has a starting point
		tempTrans = transforms [0];
		lastPos = tempTrans.position; 
		Transform pointT = tempTrans;

	}
}
*/