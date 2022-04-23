using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

	public float speed = 30f;
	int scoreSpieler1;
	int scoreSpieler2;
	public Text txtSpieler1;
	public Text txtSpieler2;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//print(col.gameObject.name);

		if(col.gameObject.name == "Spieler1")
		{
			// Aufprall mit Spieler1
			float y = hitObject(transform.position, col.transform.position, col.collider.bounds.size.y);
			//print ("Berechnung: " + y);
			// Richtung berechnen
			Vector2 dir = new Vector2(1,y);
			// Richtungsvektor auf Physik anwenden
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}

		if (col.gameObject.name == "Spieler2")
		{
			// Aufprall mit Spieler2
			float y = hitObject(transform.position, col.transform.position, col.collider.bounds.size.y);
			// Richtung berechnen
			Vector2 dir = new Vector2(-1,y);
			// Richtungsvektor auf Physik anwenden
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}

		if (col.gameObject.name == "WandVertikalRechts") {
			print ("TOR für SPIELER 1");
			scoreSpieler1 = scoreSpieler1 + 1;
			txtSpieler1.text = scoreSpieler1.ToString();
			// neustart
			restart();
		}

		if (col.gameObject.name == "WandVertikalLinks") {
			print ("TOR für SPIELER 2");
			scoreSpieler2++;
			txtSpieler2.text = scoreSpieler2.ToString();
			// neustart
			restart();
		}

		print ("Punktestand: " + scoreSpieler1 + ":" + scoreSpieler2);
	}

	float hitObject(Vector2 ballPos, Vector2 schlaegerPos, float schlaegerHoehe)
	{
		return (ballPos.y - schlaegerPos.y) / schlaegerHoehe;
	}

	void restart()
	{
		// Ball an Anstoßposition befördern
		Vector2 temp = new Vector2(0,0);
		gameObject.transform.position = temp;
	}

}
