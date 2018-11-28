using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour 
{
	public Vector2 Velocity;
	// Update is called once per frame
	void FixedUpdate () 
	{
		this.transform.Translate (Velocity * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("edge")) 
		{
			Destroy (this.gameObject);
		}
		if (other.gameObject.CompareTag("pointee"))
		{
			Destroy (other.gameObject);
			GM.instance.UpdateWallet (1);
			GM.instance.score++;
			if (GM.instance.score > 60 && GM.instance.EnemiesUntilBad >= 1)
				GM.instance.EnemiesUntilBad--;
			Destroy (this.gameObject);
		}
		if (other.CompareTag ("top")) {
			powerupManager.instance.topHealth--;
			if (powerupManager.instance.topHealth == 0) 
			{
				Destroy (other.gameObject);
				powerupManager.instance.powerUpActivate = true;
			}
			Destroy (this.gameObject);
		}
		if (other.CompareTag ("bottom")) {
			powerupManager.instance.bottomHealth--;
			if (powerupManager.instance.bottomHealth == 0) 
			{
				Destroy (other.gameObject);
				powerupManager.instance.powerUpActivate = true;
			}
			Destroy (this.gameObject);
		}
	}
}
