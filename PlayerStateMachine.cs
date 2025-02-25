using UnityEngine;

public class PlayerStateMachine
{
    //the last part mean it is read only: public when get and private when set
    public PlayerState currentState{ get; private set; }

    public void Initialize(PlayerState _startState)
    {
        currentState = _startState;
        currentState.Enter();
    }

    public void ChangeState(PlayerState _newState)
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }

}
