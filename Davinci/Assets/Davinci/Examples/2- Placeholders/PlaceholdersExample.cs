using UnityEngine;
using UnityEngine.UI;

public class PlaceholdersExample : MonoBehaviour
{
    public Image image_1;
    public Image image_2;

    public Texture2D loadingSpr, errorSpr;

    public string correctUrl;
    public string wrongUrl;

    private void Start()
    {
        //use setLoadingSprite and setError sprite to set placeholders

        Davinci.get()
            .load(correctUrl)
            .setLoadingPlaceholder(loadingSpr)
            .setErrorPlaceholder(errorSpr)
            .setCached(false)
            .into(image_1)
            .start();

        Davinci.get()
            .load(wrongUrl)
            .setLoadingPlaceholder(loadingSpr)
            .setErrorPlaceholder(errorSpr)
            .setCached(false)
            .into(image_2)
            .start();
    }
}