﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (gameObject.tag == other.tag)
		{
			Destroy(other.gameObject);
			Destroy(gameObject);

		}
	}
}
