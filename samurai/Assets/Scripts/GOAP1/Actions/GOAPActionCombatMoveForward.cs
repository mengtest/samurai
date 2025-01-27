﻿using UnityEngine;
using System.Collections.Generic;
using Phenix.Unity.AI;

public class GOAPActionCombatMoveForward : GOAPActionBase
{
    AnimFSMEventCombatMove _eventCombatMove;
    Vector3 _finalPos;

    public GOAPActionCombatMoveForward(GOAPActionType1 actionType, Agent1 agent,
        List<WorldStateBitData> WSPrecondition, List<WorldStateBitDataAction> WSEffect)
        : base((int)actionType, agent, WSPrecondition, WSEffect)
    {
        
    }

    public override void Reset()
    {
        base.Reset();
        _eventCombatMove = null;
        _finalPos = Vector3.zero;
    }

    public override void OnEnter()
    {
        SendEvent();
    }

    public override void OnExit(Phenix.Unity.AI.WorldState ws)
    {
        if (_eventCombatMove != null)
        {
            _eventCombatMove.Release();
            _eventCombatMove = null;
        }
        base.OnExit(ws);
    }

    public override bool IsFinished()
    {
        if (_eventCombatMove == null)
        {
            return true;
        }
        return _eventCombatMove.IsFinished || Agent.BlackBoard.DesiredTargetInCombatRange;
    }

    void SendEvent()
    {
        _eventCombatMove = AnimFSMEventCombatMove.pool.Get();
        _eventCombatMove.moveType = MoveType.FORWARD;
        _eventCombatMove.motionType = Agent.BlackBoard.DistanceToDesiredTarget - Agent.BlackBoard.combatRange <= 4 ? MotionType.WALK : MotionType.RUN;
        _eventCombatMove.target = Agent.BlackBoard.desiredTarget;
        _eventCombatMove.totalMoveDistance = Random.Range((Agent.BlackBoard.DistanceToDesiredTarget - Agent.BlackBoard.combatRange * 0.5f) * 0.5f, 
            Agent.BlackBoard.DistanceToDesiredTarget - Agent.BlackBoard.combatRange * 0.5f);
        _eventCombatMove.minDistanceToTarget = 3;
        Agent.FSMComponent.SendEvent(_eventCombatMove);
    }
}