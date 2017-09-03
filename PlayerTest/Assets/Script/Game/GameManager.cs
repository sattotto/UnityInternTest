using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			PlayerDamaged (1);
		}
	}

	void PlayerDamaged(int damage){
		setPlayerHP (getPlayerHP () - damage);
		if (getPlayerHP () <= 0) {
			// がめおべら
			Debug.Log ("you died!");
		}
	}

	void PlayerHealed(int heal) {
		int setHP = System.Math.Min (Player.GetComponent<Player> ().PLAYER_HP_MAX, getPlayerHP () + heal);
		setPlayerHP (setHP);
	}

	void setPlayerHP(int playerHP){
		Player.GetComponent<Player> ().playerHP = playerHP;
		Debug.Log (playerHP);
	}
	int getPlayerHP(){
		return Player.GetComponent<Player> ().playerHP;
	}
}
