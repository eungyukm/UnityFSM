using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UOP1.StateMachine;
using UOP1.StateMachine.ScriptableObjects;

[CreateAssetMenu(menuName = "State Machines/Conditions/IsMoveConditionSO")]
public class IsMoveConditionSO : StateConditionSO<IsMoveCondition>
{
    public float tresholde = 0.02f;
}

public class IsMoveCondition : Condition
{
    private Player player;
    private IsMoveConditionSO originSO => (IsMoveConditionSO)base.OriginSO;
    public override void Awake(StateMachine stateMachine)
    {
        player = stateMachine.GetComponent<Player>();
    }
    protected override bool Statement()
    {
        Vector3 movementVector = player.inputVector;
        return movementVector.sqrMagnitude > originSO.tresholde;
    }

    public override void OnStateExit()
    {
        player.moveVector = Vector3.zero;
    }
}
