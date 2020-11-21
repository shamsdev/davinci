using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteExample : MonoBehaviour
{
    public SpriteRenderer sprite;
    public string imgUrl;

    public Texture2D loadingSpr, errorSpr;

    private void Start()
    {
        Davinci.get()
            .load(imgUrl)
            .into(sprite)
            .setLoadingPlaceholder(loadingSpr)
            .setErrorPlaceholder(errorSpr)
            .setFadeTime(2f)
            .setCached(false)
            .start();
    }
}
