using System;
using MAUIHandlers.Application.CustomControls;
using Microsoft.Maui.Platform;

namespace MAUIHandlers.Application.CommonUtility
{
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
}

