using DG.Tweening;
using UnityEngine;

public class Mover : AnimationBase
{
    [SerializeField] private float _distance = 5f;

    private void Start()
    {
        transform.DOMoveZ(_distance, _duration).SetLoops(_repeat, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}