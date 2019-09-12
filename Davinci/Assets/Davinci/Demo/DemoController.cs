using UnityEngine;
using UnityEngine.UI;

public class DemoController : MonoBehaviour
{
    public Image image1, image2, image3;
    public Sprite placeholder, error;

    public string imageUrl;
    public string imageUrl2;

    private void Start()
    {
        Davinci.get()
            .load(imageUrl)
            
            .into(image1)
            .setEnableLog(true)
            .setPlaceHolder(placeholder)
            .setErrorSprite(error)
            .withDownloadProgressChangedAction((progress) =>
            {
                print(progress);
            })
            .withErrorAction((message) =>
            {
                print(message);
            })
            .start();

        Davinci.get().load(imageUrl2).into(image2).start();
    }
}