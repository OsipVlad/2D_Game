using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _back;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private CharacterView _characterView;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _back.transform);
        SpriteAnimationsConfig config = Resources.Load<SpriteAnimationsConfig>("SpriteAnimationsConfig");
        _spriteAnimator = new SpriteAnimator(config);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.idle, true, 10);
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator?.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }


}
