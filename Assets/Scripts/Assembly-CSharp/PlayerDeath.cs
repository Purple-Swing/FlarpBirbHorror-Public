using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
	public Collider Col;

	private void Start()
	{
	}

	public void OnTriggerEnter(Collider Col)
	{
		if (Col.gameObject.tag == "Flarp" && SceneManager.GetActiveScene().name != "6")
		{
			Debug.Log("DEAD");
			SceneManager.LoadScene(2);
			Cursor.lockState = CursorLockMode.None;
		}
		if (Col.gameObject.tag == "FlarpScary" && SceneManager.GetActiveScene().name == "6")
		{
			Debug.Log("DEAD");
			SceneManager.LoadScene(7);
			Cursor.lockState = CursorLockMode.None;
		}
	}

	private void Update()
	{
	}
}
