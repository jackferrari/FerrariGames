using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
		public Text info;
		public Text win;
		private int count;
		public GameObject door;

        
        private void Start()
        {
            // get the transform of the main camera
            if (Camera.main != null)
            {
                m_Cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
                // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
            }

            // get the third person character ( this should never be null due to require component )
            m_Character = GetComponent<ThirdPersonCharacter>();
			count = 0;
			win.text = "";
			info.text = "Nothing Found Yet";
        }


        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
            // read inputs
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            bool crouch = Input.GetKey(KeyCode.C);

            // calculate move direction to pass to character
            if (m_Cam != null)
            {
                // calculate camera relative direction to move:
                m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
                m_Move = v*m_CamForward + h*m_Cam.right;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                m_Move = v*Vector3.forward + h*Vector3.right;
            }
#if !MOBILE_INPUT
			// walk speed multiplier
	        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
#endif

            // pass all parameters to the character control script
            m_Character.Move(m_Move, crouch, m_Jump);
            m_Jump = false;
        }

		void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.CompareTag ("Pick Up1"))
			{
				other.gameObject.SetActive (false);
				info.text = "This is a picture of Dan Cody, Gatsby's " +
					"first mentor. Gatsby keeps a copy in his room.";
			}
			if (other.gameObject.CompareTag ("Pick Up2")) 
			{
				other.gameObject.SetActive (false);
				info.text = "This is a book that Gatsby had when he was " +
					"young. It has his teenaged schedule for the day for self-improvement.";
			}
			if (other.gameObject.CompareTag ("Pick Up3")) 
			{
				other.gameObject.SetActive (false);
				info.text = "This is the letter that Gatsby sent to Daisy the before her wedding to Tom.";
			}
			if (other.gameObject.CompareTag ("Pick Up4")) 
			{
				other.gameObject.SetActive (false);
				info.text = "This is the medal that Gatsby won during " +
					"World War I from little Montenegro. He carries it around with him.";
			}
			if (other.gameObject.CompareTag ("Pick Up5")) 
			{
				other.gameObject.SetActive (false);
				info.text = "This is a photo of Gatsby at Oxford. He carries it " +
					"around to prove that he is an Oxford man";
			}
			if (other.gameObject.CompareTag ("Pick Up6")) 
			{
				if (count == 5)
				{
					other.gameObject.SetActive (false);
					info.text = "Secret Room Found";
				}
				else
					return;
			}
			if (count < 4)
				count++;
			else 
			{
				win.text = "You have found out about Gatsby's true past!";
				door.SetActive(false);
				count++;
			}
		}
    }
}
