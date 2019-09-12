using UnityEngine;
using UnityEngine.UI;

public class CallbacksExample : MonoBehaviour
{
    public Image image;
    public string imageUrl;
    public Text statusTxt;

    public Sprite loadingSpr, errorSpr;

    private void Start()
    {
        //Use with... to add callbacks
        Davinci.get()
            .load(imageUrl)
            .into(image)
            .withStartAction(() =>
            {
                statusTxt.text = "Download has been started.";
            })
            .withDownloadProgressChangedAction((progress) =>
            {
                statusTxt.text = "Download progress: " + progress;
            })
            .withDownloadedAction(() =>
            {
                statusTxt.text = "Download has been completed.";
            })
            .withLoadedAction(() =>
            {
                statusTxt.text = "Image has been loaded.";
            })
            .withErrorAction((error) =>
            {
                statusTxt.text = "Got error : " + error;
            })
            .withEndAction(() =>
            {
                print("Operation has been finished.");
            })
            .setLoadingSprite(loadingSpr)
            .setErrorSprite(errorSpr)
            .setFadeTime(0.8f)
            .setCached(false)
            .start();
    }
}
