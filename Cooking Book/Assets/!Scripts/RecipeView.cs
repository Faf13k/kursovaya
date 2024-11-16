using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipeView : View
{
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Image _image;

    [SerializeField] private Button _backButton;

    private void OnEnable()
    {
        _backButton.onClick.AddListener(_viewManager.ShowLast);
    }

    private void OnDisable()
    {
        _backButton.onClick.RemoveListener(_viewManager.ShowLast);
    }

    public void Configure(Recipe recipe)
    {
        _name.text = recipe.Name;
        _description.text = recipe.Description;
        _image.sprite = recipe.Icon;
    }
}
