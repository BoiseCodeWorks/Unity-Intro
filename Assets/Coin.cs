using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public CoinManager CM;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
			CM = GameObject.Find("CoinManager").GetComponent<CoinManager>();
	}


	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			Debug.Log("THE PLAYER HIT ME");
			CM.OnCoinPickup(this);
		}
	}

}
