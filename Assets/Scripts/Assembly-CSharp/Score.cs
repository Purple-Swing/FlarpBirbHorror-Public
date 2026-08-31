using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text ScoreText;

	public Transform Gate;

	public Transform greatflarp;

	public Sprite FlarpiousWarpiousAngry;

	public SpriteRenderer spriteRenderer;

	public int score;

	private void Start()
	{
		Gate.gameObject.SetActive(value: false);
	}

	private void Update()
	{
		score = Mathf.FloorToInt(Time.timeSinceLevelLoad);
		ScoreText.text = score.ToString();
		if (score == 67)
		{
			Gate.gameObject.SetActive(value: false);
		}
	}
}
