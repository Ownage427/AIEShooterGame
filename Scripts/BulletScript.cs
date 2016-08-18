using UnityEngine;
using System.Collections;

[AddComponentMenu("AIE Scripts/GameDesignFoundations/BulletScript")]
public class BulletScript : MonoBehaviour {

	public GameObject bulletHitParticleEffect;
	public int damageInflicted = 100;


	// Update is called once per frame
	void OnCollisionEnter (Collision other) {
		Shootable shotObject = other.gameObject.GetComponent<Shootable>();
		if(shotObject != null) 
		{
			shotObject.IsShot (damageInflicted);
		}
		if (bulletHitParticleEffect != null) {
			Instantiate (bulletHitParticleEffect, transform.position, transform.rotation);
		}
		Destroy (gameObject);

	}
}
