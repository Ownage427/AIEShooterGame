using UnityEngine;
using System.Collections;

[AddComponentMenu("AIE Scripts/GameDesignFoundations/Always Face Camera")]
public class FaceCamera: MonoBehaviour
{
	GameObject mainCamera;
	
	void Update()
	{
		transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.back, mainCamera.transform.rotation * Vector3.up);
	}
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
	}
}