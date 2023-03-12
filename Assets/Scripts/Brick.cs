using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
	Animator myAnimator;
	// Vector3 worldPosition;
	[SerializeField] GameObject player;
	// Start is called before the first frame update
	void Start()
	{
		myAnimator = GetComponent<Animator>();
		myAnimator.SetFloat("cycle_offset", Random.Range(0f, 1f));
	}

	// Update is called once per frame
	void Update()
	{
		// Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float x_direction = player.transform.position.x - transform.position.x;
		float y_direction = transform.position.y;
		float[] x_range = {2, 5, 7};
		float[] y_range = {2.5f, 5};
		myAnimator.SetBool("top", x_direction >= -x_range[0] && x_direction < x_range[0] && y_direction < y_range[1] && y_direction >= y_range[0]);
		myAnimator.SetBool("front", x_direction >= -x_range[0] && x_direction < x_range[0] && y_direction < y_range[0]);

		myAnimator.SetBool("top_front_left", x_direction >= -x_range[1] && x_direction < -x_range[0] && y_direction < y_range[1] && y_direction >= y_range[0]);
		myAnimator.SetBool("front_left", x_direction >= -x_range[1] && x_direction < -x_range[0] && y_direction < y_range[0]);

		myAnimator.SetBool("top_left", x_direction >= -x_range[2] && x_direction < -x_range[1] && y_direction < y_range[1] && y_direction >= y_range[0]);
		myAnimator.SetBool("left", x_direction >= -x_range[2] && x_direction < -x_range[1] && y_direction < y_range[0]);

		myAnimator.SetBool("top_front_right", x_direction >= x_range[0] && x_direction < x_range[1] && y_direction < y_range[1] && y_direction >= y_range[0]);
		myAnimator.SetBool("front_right", x_direction >= x_range[0] && x_direction < x_range[1] && y_direction < y_range[0]);

		myAnimator.SetBool("top_right", x_direction >= x_range[1] && x_direction < x_range[2] && y_direction < y_range[1] && y_direction >= y_range[0]);
		myAnimator.SetBool("right", x_direction >= x_range[1] && x_direction < x_range[2] && y_direction < y_range[0]);

	}
}
