using DG.Tweening;
using UnityEngine;

public class TweenAnimationMoveLocal : TweenAnimationBase
{
    [Header("Move Local")]
    public Vector3 targetLocalPosition;

    protected override void CreateTween()
    {
        tween = transform.DOMove(targetLocalPosition, duration);
    }
}
