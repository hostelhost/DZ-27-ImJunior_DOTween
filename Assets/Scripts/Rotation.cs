using DG.Tweening;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private int _repeat = -1;
    [SerializeField] private Vector3 vector3;

    private void Start()
    {
        transform.DORotate(vector3, _duration).SetLoops(_repeat, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}