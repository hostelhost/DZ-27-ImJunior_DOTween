using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _repeat = -1;
    [SerializeField] private float _distance = 5f;

    private void Start()
    {
        transform.DOMoveZ(_distance, _duration).SetLoops(_repeat, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}