using UnityEngine;

public abstract class GameStateBase
{
    public virtual void OnEnterState() { }
    public virtual void OnStateUpdate() { }
    public virtual void OnExitState() { }
}
