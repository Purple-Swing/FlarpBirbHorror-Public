using UnityEngine;

public class FootStep : MonoBehaviour
{
	private AudioSource audioSource;

	private bool IsMoving;

	private bool IsJumping;

	private void Start()
	{
		audioSource = base.gameObject.GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
		{
			IsMoving = true;
		}
		else
		{
			IsMoving = false;
		}
		if (IsMoving && !audioSource.isPlaying)
		{
			audioSource.Play();
		}
		if (!IsMoving)
		{
			audioSource.Stop();
		}
	}
}
