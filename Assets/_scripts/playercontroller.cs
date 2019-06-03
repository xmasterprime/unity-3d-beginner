using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
	void Start()
	{
		
	}
    void Update()
    {
        float.moveHorizontal = Input.GetAxis ("Horizontal");
        float.moveVertical = Input.GetAxis ("Vertical");

        Rigidbody.AddForce()
    }
}
