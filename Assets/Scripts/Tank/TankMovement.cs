using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public int m_PlayerNumber = 1;         
    public float m_Speed = 12f;            
    public float m_TurnSpeed = 180f;       
   // public AudioSource m_MovementAudio;    
    public AudioClip m_EngineIdling;       
    public AudioClip m_EngineDriving;      
    public float m_PitchRange = 0.2f;    //Varies pitch

    private string m_MovementAxisName;     
    private string m_TurnAxisName;         
    private Rigidbody m_Rigidbody;         //moves tank around
    private float m_MovementInputValue;    
    private float m_TurnInputValue;        
    private float m_OriginalPitch;         


    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>(); //getcomponent gets reference and stores it on a game object
    }


    private void OnEnable ()
    {
        m_Rigidbody.isKinematic = false; //kinematic means no forces will be applied when false.
        m_MovementInputValue = 0f; //restarts with driving
        m_TurnInputValue = 0f;
    }


    private void OnDisable ()
    {
        m_Rigidbody.isKinematic = true;
    }


    private void Start()
    {
        m_MovementAxisName = "Vertical" + m_PlayerNumber; //uses axes for player movement
        m_TurnAxisName = "Horizontal" + m_PlayerNumber;

       // m_OriginalPitch = m_MovementAudio.pitch; //stores original pitch
    }

    private void Update()
    {
        // Store the player's input and make sure the audio for the engine is playing.
		m_MovementInputValue = Input.GetAxis (m_MovementAxisName);
		m_TurnInputValue = Input.GetAxis (m_TurnAxisName);

	//	EngineAudio ();
    }


 /*   private void EngineAudio()
    {
        // Play the correct audio clip based on whether or not the tank is moving and what audio is currently playing. //abs = positive version of a float

		if (Mathf.Abs (m_MovementInputValue) < 0.1f && Mathf.Abs (m_TurnInputValue) < 0.1f) //f = floating point value.
		{
			if (m_MovementAudio.clip == m_EngineDriving) 
			{
				m_MovementAudio.clip = m_EngineIdling;
				m_MovementAudio.pitch = Random.Range (m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange); // between .8 and 1.2
				m_MovementAudio.Play ();

			}
		} 
		else 
		{
			if (m_MovementAudio.clip == m_EngineIdling) 
			{
				m_MovementAudio.clip = m_EngineDriving;
				m_MovementAudio.pitch = Random.Range (m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange); // between .8 and 1.2
				m_MovementAudio.Play ();

			}
		}
    }

*/
    private void FixedUpdate() //uses physics steps
    {
        // Move and turn the tank.
        if (this.gameObject.GetComponent<Rigidbody>() != null){
		Move ();
		Turn ();
    }
    }


    private void Move() //how far the tank is going to move and how we are going to move it
    {
        // Adjust the position of the tank based on the player's input.
		Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime; //vector3 made of three directions

		m_Rigidbody.MovePosition (m_Rigidbody.position + movement);
    }


    private void Turn()
    {
        // Adjust the rotation of the tank based on the player's input.
		float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f); //the quaternion needs three values
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnRotation);
    }
}