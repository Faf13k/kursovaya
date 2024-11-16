using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Label : MonoBehaviour
{
    [Inject] private readonly ViewManager _viewManager;
    [SerializeField] private List<Recipe> _recipes;
    [SerializeField] private RecipeUI _UIPrefab;
    [SerializeField] private Transform _contentParent;

    public void BuildUI()
    {
        foreach (var recipe in _recipes)
        {
            RecipeUI ui = Instantiate(_UIPrefab.gameObject, _contentParent).GetComponent<RecipeUI>();
            ui.Configure(recipe, _viewManager);
        }
    }
}
