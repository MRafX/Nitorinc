using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitoriLookTarget_rot : MonoBehaviour
{
#pragma strict
 
 public Transform center;
 public Vector3 axis = Vector3.up;
 public float radius = 2.0f;
 public float radiusSpeed = 0.5f;
 public float rotationSpeed = 80.0f; 
 
 void Start() {
     transform.position = (transform.position - center.position).normalized * radius + center.position;
	}
 
 void Update() {
	 updateAngle();
     transform.RotateAround (center.position, axis, rotationSpeed * Time.deltaTime);
     var desiredPosition = (transform.position - center.position).normalized * radius + center.position;
     transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
	
	}
 void updateAngle()
    {
        Transform camTransform = Camera.main.transform;
        transform.rotation = camTransform.rotation;
    }
}
 /*
#pragma warning disable 0649	//Serialized Fields
    [SerializeField]
    private float spinSpeed;
#pragma warning restore 0649

    private float floorDistance;
    private float floorAngle;

	void Start()
	{
        Vector2 fromNitori = new Vector2(transform.position.x, transform.position.z);
        floorDistance = fromNitori.magnitude;
        floorAngle = fromNitori.getAngle();

    }
	
	void Update()
	{
        updateAngle();
        if (spinSpeed > 0f)
            updateSpin();
	}

    void updateSpin()
    {
        //Vector2 fromNitori = new Vector2(transform.position.x, transform.position.z);
        floorAngle += spinSpeed * Time.deltaTime;
        Vector2 fromNitori = MathHelper.getVector2FromAngle(floorAngle, floorDistance);
        transform.position = new Vector3(fromNitori.x, transform.position.y, fromNitori.y);
    }

    void updateAngle()
    {
        Transform camTransform = Camera.main.transform;
        transform.rotation = camTransform.rotation;
        //Vector3 cameraEulers = Camera.rotation.eulerAngles;
        //cameraEulers.Scale(new Vector3(.5f, 1f, 1f));
        //cameraEulers = new Vector3(cameraEulers.x * .5f, cameraEulers.y, cameraEulers.z);
        //transform.rotation = Quaternion.Euler(cameraEulers);
    }
}
*/