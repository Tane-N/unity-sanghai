using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public abstract class TweenAnimationBase : MonoBehaviour
{
    protected Tweener tween;
    public UnityEvent onTweenComplete;

    [Header("Universal")]
    public bool playOnStart = false;
    public float duration = 1f;
    public int loops = 0;
    public LoopType loopType = LoopType.Yoyo;
    public Ease ease = Ease.Linear;

    void Start()
    {
        CreateTween();
        SetTweenSettings();

        if (!playOnStart) return;
        TweenStart();
    }

    protected virtual void CreateTween()
    {

    }

    void SetTweenSettings()
    {
        tween.SetAutoKill(false);
        tween.Rewind();
        tween.SetEase(ease);
        tween.SetId(this.gameObject);
        tween.OnComplete(() =>
        {
            onTweenComplete?.Invoke();
        });

        if (loops == 0) return;
        tween.SetLoops(loops, loopType);
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
