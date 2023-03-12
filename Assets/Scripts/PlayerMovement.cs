using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float runSpeed = 4f;
    
    Vector2 moveInput;
    Rigidbody2D myRigidbody;
	Animator myAnimator;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
		myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2 (moveInput.x * runSpeed, moveInput.y);
        myRigidbody.velocity = playerVelocity;

		bool isMoving = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
		myAnimator.SetBool("isWalking", isMoving);
		if (isMoving) {
			transform.localScale = new Vector2 (Mathf.Sign(myRigidbody.velocity.x), 1f);
		}
    }

}
