using UnityEngine;
using UOP1.StateMachine;
using UOP1.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "HorizontalMoveAction", menuName = "State Machines/Actions/Horizontal Move Action")]
public class HorizontalMoveActionSO : StateActionSO<HorizontalMoveAction>
{
	//protected override StateAction CreateAction() => new HorizontalMoveAction();
	public float speed = 8f;
}

public class HorizontalMoveAction : StateAction
{
	private Player player;
	private HorizontalMoveActionSO origin => (HorizontalMoveActionSO)base.OriginSO;

	public override void Awake(StateMachine stateMachine)
	{
		player = stateMachine.GetComponent<Player>();
	}
		
	public override void OnUpdate()
	{
		player.moveVector.x = player.inputVector.x * origin.speed;
		player.moveVector.y = 0;
		player.moveVector.z = player.inputVector.z * origin.speed;
	}
	
	// public override void OnStateEnter()
	// {
	// }
	
	// public override void OnStateExit()
	// {
	// }
}
