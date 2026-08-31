using UnityEngine;
using UnityEngine.AI;

public class Flarp : MonoBehaviour
{
	private NavMeshAgent greatflarp;

	public Transform PlayerTarget;

	public Transform greatflarpbirb;

	public float range;

	private void Start()
	{
		greatflarp = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		greatflarp.SetDestination(PlayerTarget.position);
	}
}
