using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
	private class FileCreation
	{
		public static void Main()
		{
			using (File.CreateText("C:/Downloads"))
			{
			}
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PatchNotes()
	{
		SceneManager.LoadScene(4);
	}

	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}

	public void Menu()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	private void OnApplicationQuit()
	{
		if (SceneManager.GetActiveScene().name == "8")
		{
			File.CreateText("You thought you could escape but really he will arrive anyway");
		}
	}
}
