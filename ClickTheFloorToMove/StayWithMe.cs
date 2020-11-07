using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWithMe : MonoBehaviour
{
	
	public GameObject playerObject;
	public float sSpeed = 3f;
    public Vector3 offset;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void LateUpdate()
    {
		if(ClickFloorToMove.cftm.canmove){
			Vector3 dPos = transform.position + offset;
			Vector3 sPos = Vector3.Lerp(playerObject.transform.position, dPos, sSpeed * Time.deltaTime);
			playerObject.transform.position = sPos;
		}
    }
	
}
