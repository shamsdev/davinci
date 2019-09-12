using UnityEngine;
using UnityEngine.UI;

public class PlaceholdersExample : MonoBehaviour
{
    public Image image_1;
    public Image image_2;

    public Sprite loadingSpr, errorSpr;

    public string correctUrl;
    public string wrongUrl;

    private void Start()
    {
        //use setLoadingSprite and setError sprite to set placeholders

        Davinci.get()
            .load(correctUrl)
            .setLoadingSprite(loadingSpr)
            .setErrorSprite(errorSpr)
            .setCached(false)
            .into(image_1)
            .start();

        Davinci.get()
            .load(wrongUrl)
            .setLoadingSprite(loadingSpr)
            .setErrorSprite(errorSpr)
            .setCached(false)
            .into(image_2)
            .start();
    }
}