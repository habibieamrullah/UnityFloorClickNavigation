using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFloorToMove : MonoBehaviour
{
	RaycastHit hit;
	public GameObject movementTarget;
	
	public float clickDragDuration = .75f;
	float countDown;
	
	[HideInInspector]
	public static ClickFloorToMove cftm;
	public bool canmove;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		cftm = this;
		hit = new RaycastHit();
		canmove = false;
    }

    // Update is called once per frame
    void Update()
    {
		
		if (countDown > 0){
			countDown -= Time.deltaTime;
		}
		
		if(!canmove){
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast (ray, out hit)){
				movementTarget.transform.position = hit.point;
			}
		}

    }
	
	void OnMouseDown(){
		countDown = clickDragDuration;
	}
	
	void OnMouseUp(){
		if(countDown >= 0){
			canmove = true;
		}
	}
	
}
