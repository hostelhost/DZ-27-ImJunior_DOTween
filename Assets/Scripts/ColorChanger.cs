using DG.Tweening;
using UnityEngine;

public class ColorChanger : AnimationBase
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _spriteRenderer.DOColor(Random.ColorHSV(), _duration).OnComplete(ChangeColor);
    }
}