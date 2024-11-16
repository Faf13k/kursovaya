using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainView : View
{
    [SerializeField] private List<Label> _labels;
    public override void Initialize()
    {
        foreach (var label in _labels)
        {
            label.BuildUI();
        }
        Application.targetFrameRate = 60;
    }
}
