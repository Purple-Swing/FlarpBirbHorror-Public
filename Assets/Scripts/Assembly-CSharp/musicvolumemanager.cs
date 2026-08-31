using UnityEngine;
using UnityEngine.UI;

public class musicvolumemanager : MonoBehaviour
{
	[SerializeField]
	private Slider volumeSlider;

	private void Start()
	{
		if (!PlayerPrefs.HasKey("musicVolume"))
		{
			PlayerPrefs.SetFloat("musicVolume", 0.5f);
			LoadVolume();
		}
		else
		{
			LoadVolume();
		}
	}

	public void VolumeChange()
	{
		AudioListener.volume = volumeSlider.value;
		SaveVolume();
	}

	private void LoadVolume()
	{
		volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
	}

	private void SaveVolume()
	{
		PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
	}
}
