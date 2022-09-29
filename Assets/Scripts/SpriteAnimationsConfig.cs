using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpriteAnimationsConfig", menuName = "Skripts/SpriteAnimationsConfig", order = 1)]
public class SpriteAnimationsConfig : ScriptableObject
{
    [SerializeField]
    private List<SpritesSequence> _sequences;

    public List<SpritesSequence> Sequences => _sequences;
}
