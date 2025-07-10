using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameStateBase currentState;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetGameState(new GameStateGameStart());
    }

    public void SetGameState(GameStateBase state)
    {
        if (currentState != null)
        {
            currentState.OnExitState();
        }

        currentState = state;
        currentState.OnEnterState();
    }

    void Update()
    {
        if (currentState == null) return;
        currentState.OnStateUpdate();
    }
}
