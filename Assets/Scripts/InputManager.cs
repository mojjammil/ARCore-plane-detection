using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public GameObject cubePrefab;

	void Update()
	{
		itemInstantiate();
	}

	private void itemInstantiate()
	{
		foreach(var t in Input.touches){
			if(t.phase != TouchPhase.Began)
			continue; 
			var ray = Camera.main.ScreenPointToRay(t.position);
			RaycastHit hitInfo;
			if(Physics.Raycast(ray, out hitInfo)){
				var go = GameObject.Instantiate(cubePrefab, hitInfo.point + Vector3.up, Quaternion.identity);
				go.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
			}
		}
	}

	private void activeObject()
	{
		
	}
	
}
