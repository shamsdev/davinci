using UnityEngine;
using UnityEngine.UI;

public class TextureExamlpe : MonoBehaviour
{
    public Renderer cube1, cube2;
    public string imgUrl1, imgUrl2;

    public Texture2D loadingSpr, errorSpr;

    private void Start()
    {
        Davinci.get()
            .load(imgUrl1)
            .into(cube1)
            .setLoadingPlaceholder(loadingSpr)
            .setErrorPlaceholder(errorSpr)
            .setFadeTime(2f)
            .setCached(false)
            .start();

        Davinci.get()
            .load(imgUrl2)
            .into(cube2)
            .setLoadingPlaceholder(loadingSpr)
            .setErrorPlaceholder(errorSpr)
            .setFadeTime(0f)
            .setCached(false)
            .start();
    }
}
