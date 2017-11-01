using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerwalk : MonoBehaviour {
    private float speed = 6;
	private int health = 10;

    void Update () {
        float axisX = Input.GetAxis ("Horizontal");
        float axisY = Input.GetAxis ("Vertical");

        transform.Translate (new Vector3 (axisX, axisY) *Time.deltaTime * speed);
		
		if (health <= 0){
			Destroy(gameObject);
		}
    }
	
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Enemy"){
			//Destroy(other.gameObject);
			health--;
			Debug.Log ("Health: " + health);
		}
	}
}
