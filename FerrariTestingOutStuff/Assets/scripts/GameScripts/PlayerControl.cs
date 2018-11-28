using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour 
{
	public GameObject projectile;
	public float spin;
	public float fasterSpin;
	public float slowerSpin;
	public float turningSpin;
	public float initialSpeed;

	public bool isSprinting;
	public int waitTime;
	public int countDown;

	public int recoveryTime;
	public int diagnosis;
	public bool hasThePlague;

	void Awake()
	{
		countDown = waitTime;
		hasThePlague = false;
	}

	// Update is called once per frame
	void Update ()
	{
		turningSpin = 0;



		if (hasThePlague == true) 
		{
			recoveryTime--;
			if (recoveryTime == 0) 
			{
				hasThePlague = false;
			}
		}
		if ((Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) && GM.instance.ActualMoney > 0) 
		{
			isSprinting = true;
		} else 
		{
			isSprinting = false;
		}



		if (Input.GetKey (KeyCode.A)) 
		{
			turningSpin = spin + initialSpeed;
			if (isSprinting == true)
			{
				turningSpin = turningSpin * fasterSpin;
				if (countDown == 0) 
				{
					GM.instance.UpdateWallet (-1);
					countDown = waitTime;
				} else
					countDown--;
			}
		}
	
		if (Input.GetKey (KeyCode.D)) 
		{
			turningSpin = -spin - initialSpeed;
			if (isSprinting == true)
			{
				turningSpin = turningSpin * fasterSpin;
				if (countDown == 0) 
				{
					GM.instance.UpdateWallet (-1);
					countDown = waitTime;
				} 
				else
					countDown--;
			}
		}
		if (recoveryTime > 0) 
		{
			turningSpin = turningSpin * slowerSpin;
		}
		transform.Rotate (new Vector3 (0, 0, turningSpin) * Time.deltaTime);



		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			for (int i = 0; i < powerupManager.instance.power; i++) {
				Instantiate (projectile, transform.position, transform.rotation);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if ((other.CompareTag ("pointee")) || (other.CompareTag ("otherPoint")) || (other.CompareTag ("moneyman"))) {
			Destroy (other.gameObject);
			GM.instance.loseHealth (1);	
		}
		if (other.CompareTag ("plague")) {
			Destroy (other.gameObject);
			hasThePlague = true;
			recoveryTime = diagnosis;
		}
	}
}
