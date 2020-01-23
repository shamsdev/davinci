Davinci
---
🖼 A powerful, esay-to-use image downloading and caching library for **Unity** in Run-Rime! 😎 

![](https://user-images.githubusercontent.com/15744733/64790065-b75c6680-d58a-11e9-843d-4831fbc60306.gif)

Simple usage - Single line of code and ready to go!
```csharp
Davinci.get().load(imageUrl).into(image).start();
```

🔴Update : Support for any types of Renderer component has been added. now we can download 3d models textures in run-time!

![](https://user-images.githubusercontent.com/15744733/72981848-021ca380-3df3-11ea-89b4-1a1d7a6fd225.gif)


Features
---
### Customizable image placeholders

![](https://user-images.githubusercontent.com/15744733/64792966-7b77d000-d58f-11e9-853f-3ad438375ec6.gif)
```csharp
Davinci.get()
    .load(url)
    .setLoadingPlaceholder(loadingSpr)
    .setErrorPlaceholder(errorSpr)
    .into(image)
    .start();
```

### Loading Fade Time

![](https://user-images.githubusercontent.com/15744733/64794033-2d63cc00-d591-11e9-981d-167704a92be7.gif)
```csharp
Davinci.get()
    .load(url)
    .setFadeTime(2) // 0 for disable fading
    .into(image)
    .start();
```

### Fully access to operation progress and callbacks

![](https://user-images.githubusercontent.com/15744733/64794838-5c2e7200-d592-11e9-90df-ec39b89b0aab.gif)
```csharp
Davinci.get()
    .load(imageUrl)
    .into(image)
    .withStartAction(() =>
    {
        Debug.Log("Download has been started.");
    })
    .withDownloadProgressChangedAction((progress) =>
    {
        Debug.Log("Download progress: " + progress);
    })
    .withDownloadedAction(() =>
    {
        Debug.Log("Download has been completed.");
    })
    .withLoadedAction(() =>
    {
        Debug.Log("Image has been loaded.");
    })
    .withErrorAction((error) =>
    {
        Debug.Log("Got error : " + error);
    })
    .withEndAction(() =>
    {
        Debug.Log("Operation has been finished.");
    })
    .start();
```

Also:
- Supports Unity UI Image Component
- Compatible with all platforms and unity versions.

Usage
----
Clone the project. Open Davinci/Assets in with unity or import UnityPackage to your existing project.

You can see lots of examples in Assets/Examples

Please see Wiki page for more information and examples

Development
----
Want to contribute? Great! 

Make a change in your file and instantaneously see your updates!

TODO
----
 - Add support for textures ✅ 
 - Improvements

License
----
**Davinci** is available under the **MIT** license. See the LICENSE file for more info.

