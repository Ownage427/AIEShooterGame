using UnityEngine;
using System.Collections;

[AddComponentMenu("AIE Scripts/GameDesignFoundations/EnemyFire")]
public class EnemyFire : MonoBehaviour {
	//public GameObject enemy;
	public GameObject barrel;
	public float firingRange = 20.0f;
	public float bulletSpeed;
	private float shootTime = 0.0f;
	public float shotInterval = 0.2f; // interval between shots
	public Rigidbody bulletPrefab; // drag the bullet prefab heree;
	Ray ray;
	RaycastHit hit;

	void Update () {

		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit, firingRange)) {
			if ((hit.collider.gameObject.tag == "Player") || hit.collider.gameObject.tag == "Enemy") {
				if (Time.time >= shootTime) { // if it's time to shoot...
					Rigidbody bullet = (Rigidbody)Instantiate (bulletPrefab, barrel.transform.position, barrel.transform.rotation);
					bullet.AddForce (transform.forward * bulletSpeed); // shoot in the target direction
					shootTime = Time.time + shotInterval; // set time for next shot
				}
			}
		}
	}

	void BulletFire() {
		Instantiate (bulletPrefab, barrel.transform.position, transform.rotation);
		bulletPrefab.GetComponent<Rigidbody> ().AddForce (bulletPrefab.transform.forward * bulletSpeed);
	}
}

