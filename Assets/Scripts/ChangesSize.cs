using DG.Tweening;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChangesSize : MonoBehaviour
{
    [SerializeField] private float _duration = 4f;
    [SerializeField] private float _size = 2f;
    [SerializeField] private int _repeat = -1;

    private void Start()
    {
        transform.DOScale(_size, _duration).SetLoops(_repeat, LoopType.Yoyo).SetEase(Ease.Linear);
    }           
}
