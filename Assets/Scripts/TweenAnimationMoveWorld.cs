using DG.Tweening;
using UnityEngine;

public class TweenAnimationMoveWorld : TweenAnimationBase
{
    [Header("Move")]
    public Vector3 targetWorldPosition;

    protected override void CreateTween()
    {
        tween = transform.DOMove(targetWorldPosition, duration);
    }
}
