using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteManager : IDisposable
{

    private Vector3 _startPosition;
    private LevelObjectView _characterView;
    private List<LevelObjectView> _deathZones;
    private List<LevelObjectView> _winZones;

    public LevelCompleteManager(LevelObjectView characterView, List<LevelObjectView> deathZone, List<LevelObjectView> winZone)
    {
        _startPosition = characterView.Transform.position;
        characterView.OnLevelObjectContact += OnLevelObjectContact;

        _characterView = characterView;
        _deathZones = deathZone;
        _winZones = winZone;
    }

    private void OnLevelObjectContact(LevelObjectView contactView)
    {
        if (_deathZones.Contains(contactView))
        {
            _characterView.Transform.position = _startPosition;
        }
    }

    public void Dispose()
    {
        _characterView.OnLevelObjectContact -= OnLevelObjectContact;
    }
}
