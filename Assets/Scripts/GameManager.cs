using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameStateBase currentState;
    public UnityEvent onStateChange;

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
        onStateChange?.Invoke();
    }

    void Update()
    {
        if (currentState == null) return;
        currentState.OnStateUpdate();
    }
}
