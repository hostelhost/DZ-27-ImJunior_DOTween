using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : AnimationBase
{
    [SerializeField] private Text _text;
    [SerializeField] private string _name;
    [SerializeField] private string _post;
    [SerializeField] private string _responsibilities;

    private Sequence _sequence;

    private void Start()
    {
        _sequence = DOTween.Sequence();
        _sequence.Append(_text.DOText(_name, _duration).SetDelay(_duration));
        _sequence.Append(_text.DOText(_post, _duration).SetRelative());
        _sequence.Append(_text.DOText(_responsibilities, _duration, true, ScrambleMode.All));

        _sequence.SetLoops(_repeat, LoopType.Restart);
    }
}
