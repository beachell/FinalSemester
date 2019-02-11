using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
	public int currentJumpNum = 0;
	int maxJump = 1;
	public float maxS = 5f;

	public float jumpHeight = 5f;
	float moveVelocity;
	public int GravityForces = -10;
	
	private Rigidbody rb;
	
	public float mouseSensitivity = 100.0f;
	public float clampAngle = 80.0f;
 
	private float rotY = 0.0f; // rotation around the up/y axis
	private float rotX = 0.0f; // rotation around the right/x axis
	private float waitTime = .0001f;

	public Vector3 rot;
	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		StartCoroutine(Mover());
		rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;
	}

	IEnumerator Mover()
	{
		while (true)
		{
			Physics.gravity = new Vector3(0, GravityForces, 0);
			//-----------------------------------------------------------------movement 

			
			float movex = Input.GetAxis("Horizontal");
			float movez = Input.GetAxis("Vertical");
			rb.velocity = new Vector3(movex * maxS, rb.velocity.y, movez *maxS);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				Jump();
			}
			float mouseX = Input.GetAxis("Mouse X");
			float mouseY = -Input.GetAxis("Mouse Y");

			rotY += mouseX * mouseSensitivity * Time.deltaTime;
			rotX += mouseY * mouseSensitivity * Time.deltaTime;

			rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

			Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
			transform.rotation = localRotation;
			
			yield return new WaitForSeconds(waitTime);
		}
	}
	
	void Jump()
	{
		if (currentJumpNum < maxJump)
		{
			rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0f);
			currentJumpNum++;
		}
	}
	
	void OnCollisionEnter (Collision col)
	{
		currentJumpNum = 0;
	}

}
/*
 * 	
	private Animator myAnimator;

	//-------------------lightthings
	public Light rabbitLight;
	public Color color0 = Color.white;
	public Color color1 = Color.red;
	public float colorLightTime = 0.5f;
	//-----------------------------

	public GameObject plusOne;
	public GameObject ZeroIcon;
	public GameObject GameOverObject;



	void Start(){
		myAnimator = GetComponent<Animator>();
		gameObject.SetActive (true);
		rabbitLight = GetComponent<Light>();
		starCount = 0;
	}

	void FixedUpdate()
	{
		Physics.gravity = new Vector3 (0,GravityForces, 0);
		//-----------------------------------------------------------------movement 

			myAnimator.SetFloat ("maxS", Mathf.Abs (Input.GetAxis ("Horizontal")));
			transform.Translate (new Vector3 (notMovingSpeed, 0, 0) * Time.deltaTime);
			float move = Input.GetAxis ("Horizontal");
			GetComponent<Rigidbody> ().velocity = new Vector2 (move * maxS, GetComponent<Rigidbody> ().velocity.y);
			if (move > 0 && !right)
				Flip ();
			else if (move < 0 && right)
				Flip ();
	
//--------------------------------------------------------------------------------------
		//------------ boundry set up


		//-------------
		if (Input.GetKeyDown (KeyCode.Space)) {
			

			Jump();
		} 	
		if (Input.GetKeyDown (KeyCode.UpArrow)) {


			Jump();
		} 	

		PrintingScore ();
	
	}



	//used to flip the sprite-----------------
	void Flip()
	{
		right = !right;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		notMovingSpeed *= -1;
	}




	void PrintingScore()
	{
		scoreText.text = "Stars " + starCount.ToString ();
	}

	void OnCollisionEnter (Collision col)
	{

		currentJumpNum = 0;

		if (col.gameObject.tag == "Star") {
			
			starCount++;
			//print (starCount);
			Vector3 spawnPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			Quaternion spwanRotation = Quaternion.identity;
			Instantiate (plusOne, spawnPosition, spwanRotation);


		} 

		if (col.gameObject.tag == "BoundryLeft") {
			Destroy (gameObject);
			//--------------------------------------------------------------
			//enable the game over buttons here.
			//-------------------------------------


			GameOverObject.SetActive (true);
		}

		if (col.gameObject.tag == "Cactus") {

			float t = Mathf.PingPong (Time.time, colorLightTime) / colorLightTime;

			rabbitLight.color = Color.Lerp (color1, color0, t);

			Vector3 spawnPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			Quaternion spwanRotation = Quaternion.identity;
			Instantiate (ZeroIcon, spawnPosition, spwanRotation);


		}

	}

	void OnCollisionExit (Collision col)
	{
		if(col.gameObject.tag == "Ground"){
		}

		if (col.gameObject.tag == "Cactus") {

			
			float t = Mathf.PingPong (Time.time, colorLightTime) / colorLightTime;
			rabbitLight.color = Color.Lerp(color0, color1, t);



			if (starCount < 1)
			{
				//starCount --;
				//print (starCount);
				starCount = 0;
			}
			else{
				//starCount = 0;	
				starCount --;
			}

		}

	}
	}*/