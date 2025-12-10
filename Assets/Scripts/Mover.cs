using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(transform.position, _duration);
    }
}