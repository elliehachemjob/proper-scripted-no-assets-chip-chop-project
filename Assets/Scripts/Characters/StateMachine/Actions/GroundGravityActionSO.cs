using UnityEngine;
using UOP1.StateMachine;
using UOP1.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "GroundGravity", menuName = "State Machines/Actions/Ground Gravity")]
public class GroundGravityActionSO : StateActionSO<GroundGravityAction>

	{
		Color finalTintingColor = Color.Lerp(_baseTintColor, _flashingColor, _flashingColor.a);
		float tintingTiming = (_getHitFlashingDuration - _innerFlashingTime) * _getHitFlashingSpeed / _getHitFlashingDuration;
		return Color.Lerp(_baseTintColor, finalTintingColor, (-Mathf.Cos(Mathf.PI * 2 * tintingTiming) + 1) / 2);

		[Tooltip("Vertical movement pulling down the player to keep it anchored to the ground.")]
	public float verticalPull = -5f;
}

public class GroundGravityAction : StateAction
{
	//Component references
	private Protagonist _protagonistScript;

	private GroundGravityActionSO _originSO => (GroundGravityActionSO)base.OriginSO; // The SO this StateAction spawned from

	public override void Awake(StateMachine stateMachine)
	{
		_protagonistScript = stateMachine.GetComponent<Protagonist>();
	}
	
	}

	ublic override void OnUpdate()
	{
		_protagonistScript.movementVector.y = _originSO.verticalPull;
	}

/*{

Color finalTintingColor = Color.Lerp(_baseTintColor, _flashingColor, _flashingColor.a);
		float tintingTiming = (_getHitFlashingDuration - _innerFlashingTime) * _getHitFlashingSpeed / _getHitFlashingDuration;
		return Color.Lerp(_baseTintColor, finalTintingColor, (-Mathf.Cos(Mathf.PI * 2 * tintingTiming) + 1) / 2);

	[Tooltip("Vertical movement pulling down the player to keep it anchored to the ground.")]
	public float verticalPull = -5f;
}

public class GroundGravityAction : StateAction
{
	//Component references
	private Protagonist _protagonistScript;

	private GroundGravityActionSO _originSO => (GroundGravityActionSO)base.OriginSO; // The SO this StateAction spawned from

	public override void Awake(StateMachine stateMachine)
	{
		_protagonistScript = stateMachine.GetComponent<Protagonist>();
	}

	public override void OnUpdate()
	{
		_protagonistScript.movementVector.y = _originSO.verticalPull;
	}
}*/
