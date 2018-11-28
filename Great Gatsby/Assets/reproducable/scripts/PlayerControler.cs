using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour 
{

	public float speed;
	public Text countText;
	public Text WinText;

	private Rigidbody rb;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		WinText.text = "";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 move = new Vector3 (moveHorizontal, 0.0f, moveVertical);


			rb.AddForce(move * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pickup")) 
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText();
		}

	}

	void SetCountText()
	{
		countText.text = "Score: " + count.ToString();
		if (count >= 15)
		{
			WinText.text = "You Win";
		}
	}
}
