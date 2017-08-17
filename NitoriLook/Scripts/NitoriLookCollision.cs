using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitoriLookCollision : MonoBehaviour {
public int colisionx;
public int colisiony;
public int colisionz;
public GameObject objeto;
public float count;



	// Use this for initialization
	void Start () {
		
	}
	
	
	// Update is called once per frame
	void Update () {
	if ((transform.position.x-2 < objeto.transform.position.x) && (transform.position.x+2 > objeto.transform.position.x))
	{colisionx = 1;} else {colisionx = 0;}
	if ((transform.position.y-1.5 < objeto.transform.position.y) && (transform.position.y+1.5 > objeto.transform.position.y))
	{colisiony = 1;} else {colisiony = 0;}
	if ((transform.position.z-1.5 < objeto.transform.position.z) && (transform.position.z+1.5 > objeto.transform.position.z))
	{colisionz = 1;} else {colisionz = 0;}
	
	if (colisionx == 1 && colisiony == 1 && colisionz == 1) {count += 1*Time.timeScale;}
	else {count = 0; MicrogameController.instance.setVictory(false, false);}
	
	if (count > 40 && count < 90) {MicrogameController.instance.setVictory(true, false); }
	if (count > 90) {MicrogameController.instance.setVictory(true, true); }
	}
}
