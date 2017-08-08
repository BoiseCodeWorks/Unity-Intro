using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour {

	public List<Coin> Coins = new List<Coin>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCoinPickup(Coin coin){
		Coins.Remove(coin);
		if(Coins.Count == 0){
			Debug.Log("YOU WIN");
		}

	}


}
