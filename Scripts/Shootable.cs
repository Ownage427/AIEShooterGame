using UnityEngine;
using System.Collections;

[AddComponentMenu("AIE Scripts/GameDesignFoundations/Shootable")]
public class Shootable : MonoBehaviour {

	public GameObject particleEffectWhenShot;
	public GameObject particleEffectWhenInjured;
	public float delayBeforeDeath = 0;
	public int health = 100;

	public void IsShot (int damageInflicted) {
		StartCoroutine (Die (damageInflicted));
	}

	IEnumerator Die(int damageInflicted){
		health -= damageInflicted;
		Debug.Log ("Shot object has health of: " + health);
		if (health <= 0) {
			yield return new WaitForSeconds (delayBeforeDeath);
			if (particleEffectWhenShot != null) {			
				Instantiate (particleEffectWhenShot, transform.position, transform.rotation);
			}
			Destroy (gameObject);
		}
		if ((health > 0) && (particleEffectWhenInjured != null)) {
			Instantiate (particleEffectWhenInjured, transform.position, transform.rotation);
		}
		yield return null;
	}
}
