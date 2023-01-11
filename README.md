# .NET MAUI Boderless Event Hnadler with Material Entry Ui Controls 

.Net MAUI Boderless event handler with material entry controls with all validation type and error messages and helping text


# Getting Started
After creating new .NET MAUI Project 
Create Hndler Utility with below code sanp

public class HndlerUtility
{
    public static void ModifyEntry()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
            if(view is BorderlessEntry)
            {
#if ANDROID
             handler.PlatformView.Background = null;
             handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif IOS || MACCATALYST
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth= 0;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                        handler.PlatformView.BorderThickness= new Microsoft.Ui.Xaml.Thickness(0)
#endif
            }

        });
    }
}

Use below namesapce for boderless entry
xmlns:components="clr-namespace:MAUIHandlers.Application.CustomControls"

Use as control
 <Frame Padding="10,5,5,5">
       <components:BorderlessEntry HeightRequest="40"
      Placeholder="First name"
      Keyboard="Text"
      ReturnType="Next" /> 
  </Frame>

Please have below beautiful  UI 

<img width="1027" alt="MACOS" src="https://user-images.githubusercontent.com/100989615/211735082-3e0dd34a-8e7f-4d8c-a052-bd3e347c6240.png">

![And![iOS](https://user-images.githubusercontent.com/100989615/211735155-03f3db0c-38e7-4c4f-bd03-24f8d81d931c.jpg)

![Android_Image](https://user-images.githubusercontent.com/100989615/211735375-89498c78-d01a-4283-8c16-f864f4591bc7.jpg)



