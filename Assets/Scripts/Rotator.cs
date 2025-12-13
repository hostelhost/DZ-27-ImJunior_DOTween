using DG.Tweening;
using UnityEngine;

public class Rotator : AnimationBase
{
    [SerializeField] private Vector3 vector3;

    private void Start()
    {
        transform.DORotate(vector3, _duration).SetLoops(_repeat, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}