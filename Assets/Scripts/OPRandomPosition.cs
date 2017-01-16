using UnityEngine;
using System.Collections;

public class OPRandomPosition : MonoBehaviour {

	// Use this for initialization
	void Start() {
		StartCoroutine(RePositionWithDelay());
	}

	IEnumerator RePositionWithDelay() {
		while (true) {
			SetRandomPosition();
			yield return new WaitForSeconds(3);
		}
	}

	void SetRandomPosition() {
		float x = Random.Range(-10.0f, 10.0f);
		float z = Random.Range(-10.0f, 10.0f);
		Debug.Log("X,Z: " + x.ToString("F2") + "," + z.ToString("F2"));
		transform.position = new Vector3(x, 0.0f, z);
	}
	// Update is called once per frame
	void Update() {

	}
}
