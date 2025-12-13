using UnityEngine;

public abstract class AnimationBase : MonoBehaviour
{
    [SerializeField] protected float _duration = 2f;
    [SerializeField] protected int _repeat = -1;
}