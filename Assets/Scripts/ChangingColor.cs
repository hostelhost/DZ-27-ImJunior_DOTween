using DG.Tweening;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _duration = 1.5f;

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _spriteRenderer.DOColor(Random.ColorHSV(), _duration).OnComplete(ChangeColor);
    }
}