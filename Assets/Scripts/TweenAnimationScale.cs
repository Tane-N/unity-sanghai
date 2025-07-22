using DG.Tweening;
using UnityEngine;

public class TweenAnimationScale : TweenAnimationBase
{
    [Header("Scale")]
    public float scaleMultiplier = 1.2f;

    protected override void CreateTween()
    {
        tween = transform.DOScale(transform.localScale * scaleMultiplier, duration);
    }
}
