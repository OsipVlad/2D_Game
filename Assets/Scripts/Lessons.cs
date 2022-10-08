using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _back;
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private SpriteAnimationsConfig _spriteAnimationConfig;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroPhysicsWalker _mainHeroPhysicsWalker;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _back.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);

    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();

    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalker.FixedUpdate();
    }

    private void OnDestroy()
    {
        
    }


}
