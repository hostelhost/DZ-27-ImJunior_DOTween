using DG.Tweening;
using UnityEngine;

public class SizeChanger : AnimationBase
{
    [SerializeField] private float _size = 2f;

    private void Start()
    {
        transform.DOScale(_size, _duration).SetLoops(_repeat, LoopType.Yoyo).SetEase(Ease.Linear);
    }           
}