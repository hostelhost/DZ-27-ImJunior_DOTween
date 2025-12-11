using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private float _duration = 7f;
    [SerializeField] private Text _text;
    [SerializeField] private string _name;
    [SerializeField] private string _post;
    [SerializeField] private string _responsibilities;


    private void Start()
    {
        ÑhangeTextName();
    }

    private void ÑhangeTextName()
    {
        _text.DOText(_name, _duration).OnComplete(ÑhangeTextPost).SetDelay(_duration);
    }

    private void ÑhangeTextPost()
    {
        _text.DOText(_post, _duration).OnComplete(ÑhangeTextResponsibilities).SetRelative();
    }

    private void ÑhangeTextResponsibilities()
    {
        _text.DOText(_responsibilities, _duration, true, ScrambleMode.All).OnComplete(ÑhangeTextName);
    }
}
