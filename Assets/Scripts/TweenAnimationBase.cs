using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public abstract class TweenAnimationBase : MonoBehaviour
{
    protected Tweener tween;
    public UnityEvent onTweenComplete;
    public float duration = 1f;
    public Ease ease = Ease.Linear;

    void Start()
    {
        CreateTween();
        SetTweenSettings();
    }

    protected virtual void CreateTween()
    {

    }

    void SetTweenSettings()
    {
        tween.Rewind();
        tween.SetEase(ease);
        tween.SetAutoKill(false);
        tween.OnComplete(() =>
        {
            onTweenComplete?.Invoke();
        });
    }

    public void TweenStart()
    {
        if (tween == null) return;
        tween.PlayForward();
    }

    public void TweenStop()
    {
        if (tween == null) return;
        tween.Rewind();
    }
    
    public void TweenRewind()
    {
        if (tween == null) return;
        tween.SmoothRewind();
    }
}
