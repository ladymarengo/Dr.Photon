using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
	private GameObject camera;
	[SerializeField] float camera_x;
	private float start_position;
	private float interval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Follow Camera");
		start_position = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
		camera_x = camera.transform.position.x;
		// transform.position = new Vector3(start_position + camera.transform.position.x, transform.position.y, transform.position.z);
        if (camera.transform.position.x > start_position + interval) {
			transform.position = new Vector3(start_position + interval, transform.position.y, transform.position.z);
			start_position += interval;
		} else if (camera.transform.position.x < start_position - interval) {
			transform.position = new Vector3(start_position - interval, transform.position.y, transform.position.z);
			start_position -= interval;
		}
    }
}
