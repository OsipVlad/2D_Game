using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _back;
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private SpriteAnimationsConfig _spriteAnimationConfig;
    [SerializeField] private CannonView _cannonView;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroPhysicsWalker _mainHeroPhysicsWalker;
    private CannonController _cannonController;

    private void Awake()
    {
        _paralaxManager = new ParalaxManager(_camera, _back.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);
        _cannonController = new CannonController(_cannonView._muzzleT, _characterView.transform);
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        _cannonController.Update();
    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalker.FixedUpdate();
    }

    private void OnDestroy()
    {
        
    }


}
