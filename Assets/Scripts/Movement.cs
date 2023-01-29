using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public Rigidbody playerRigid;

	public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;

	public Transform playerTrans;

	public Animator playerAnim;

	public Animator BasketAnim;


	void FixedUpdate()
	{

		if (Input.GetKey(KeyCode.W))
		{

			playerRigid.velocity = transform.forward * w_speed * Time.deltaTime;

		}

		if (Input.GetKey(KeyCode.S))
		{

			playerRigid.velocity = -transform.forward * wb_speed * Time.deltaTime;

		}

	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{

			playerAnim.SetBool("walking", true);
			playerAnim.SetBool("idle", false);
			BasketAnim.SetBool("Walking", true);

		}

		if (Input.GetKeyUp(KeyCode.W))
		{

			playerAnim.SetBool("idle", true);
			playerAnim.SetBool("walking", false);
			BasketAnim.SetBool("Walking", false);

		}


		if (Input.GetKey(KeyCode.A))
		{

			playerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);

			BasketAnim.SetBool("Left", true);
		}
		else
        {
			BasketAnim.SetBool("Left", false);
		}

		if (Input.GetKey(KeyCode.D))
		{

			playerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);

			BasketAnim.SetBool("Right", true);
		}
		else
		{
			BasketAnim.SetBool("Right", false);
		}
	}
}
