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
		float direction = player.transform.position.x - transform.position.x;
		myAnimator.SetBool("left_light", direction < -2 && direction > -4);
		myAnimator.SetBool("front_light", direction >= -2 && direction <= 2);
		myAnimator.SetBool("right_light", direction > 2 && direction < 4);
    }
}
