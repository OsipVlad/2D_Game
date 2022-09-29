using UnityEngine;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [Header("Settings")]
    [SerializeField] private float _walkSpeed = 1f;

    [SerializeField] private float _animationSpeed = 3f;

    [SerializeField] private float _jumpStartSpeed = 2f;

    [SerializeField] private float _moveThresh = 0.1f;

    [SerializeField] private float _flyThresh = 0.4f;

    [SerializeField] private float _groundLevel = 0.5f;

    [SerializeField] private float _acceleration = -10f;
    public SpriteRenderer SpriteRenderer => _spriteRenderer;

    public float WalkSpeed => _walkSpeed;
    public float AnimationSpeed => _animationSpeed;
    public float JumpStartSpeed => _jumpStartSpeed;
    public float MoveThresh => _moveThresh;
    public float FlyThresh => _flyThresh;
    public float GroundLevel => _groundLevel;
    public float Acceleration => _acceleration;
}
