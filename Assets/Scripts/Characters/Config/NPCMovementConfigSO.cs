using UnityEngine;

public class NPCMovementConfigSO : ScriptableObject
{
		[SerializeField] private float _stopDuration;
	[SerializeField] private float _speed;

	public float Speed => _speed;
	public float StopDuration => _stopDuration;
09
	/* 
	[SerializeField] private float _stopDuration;
	[SerializeField] private float _speed;

	public float Speed => _speed;
	public float StopDuration => _stopDuration;*/
}
