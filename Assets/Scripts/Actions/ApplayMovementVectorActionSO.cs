using UnityEngine;
using UOP1.StateMachine;
using UOP1.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "ApplayMovementVectorAction", menuName = "State Machines/Actions/Applay Movement Vector Action")]
public class ApplayMovementVectorActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new ApplayMovementVectorAction();
}

public class ApplayMovementVectorAction : StateAction
{
	private Player player;
	private CharacterController characterController;
	public override void Awake(StateMachine stateMachine)
	{
		player = stateMachine.GetComponent<Player>();
		characterController = player.GetComponent<CharacterController>();
	}
		
	public override void OnUpdate()
	{
		characterController.Move(player.moveVector * Time.deltaTime);
	}
	
	// public override void OnStateEnter()
	// {
	// }
	
	// public override void OnStateExit()
	// {
	// }
}
