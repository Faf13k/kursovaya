using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RecipeUI : MonoBehaviour
{
    private TMP_Text _name => GetComponentInChildren<TMP_Text>();
    private Image _image => GetComponent<Image>();
    private Button Button => GetComponent<Button>();

    public void Configure(Recipe recipe, ViewManager manager)
    {
        _name.text = recipe.Name;
        _image.sprite = recipe.Icon;
        Button.onClick.AddListener(() => ShowRecipe(recipe, manager));
    }

    private void ShowRecipe(Recipe recipe, ViewManager manager)
    {
        manager.GetView<RecipeView>().Configure(recipe);
        manager.Show<RecipeView>();
    }
}
