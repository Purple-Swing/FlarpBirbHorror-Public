using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectBirbBall : MonoBehaviour
{
	public int balls;

	public Text balltext;

	private void Start()
	{
	}

	public void OnTriggerEnter(Collider greatflarpball)
	{
		if (greatflarpball.gameObject.tag == "FlarpCoin" && SceneManager.GetActiveScene().name != "6")
		{
			Debug.Log("Ball Collection!");
			balls++;
			greatflarpball.gameObject.SetActive(value: false);
			balltext.text = balls + "/8";
		}
		if (greatflarpball.gameObject.tag == "FlarpCoin" && SceneManager.GetActiveScene().name == "6")
		{
			Debug.Log("Ball Collection!");
			balls++;
			greatflarpball.gameObject.SetActive(value: false);
			balltext.text = balls + "/";
		}
	}

	private void Update()
	{
		if (balls == 8 && SceneManager.GetActiveScene().name == "1")
		{
			SceneManager.LoadScene(5);
			Cursor.lockState = CursorLockMode.None;
		}
		if (balls == 8 && SceneManager.GetActiveScene().name == "5")
		{
			SceneManager.LoadScene(6);
			Cursor.lockState = CursorLockMode.None;
		}
		if (balls == 9 && SceneManager.GetActiveScene().name == "6")
		{
			Application.Quit();
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
