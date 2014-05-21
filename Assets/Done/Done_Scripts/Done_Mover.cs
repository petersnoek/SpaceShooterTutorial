using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;
	// comment
	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
	}
}
