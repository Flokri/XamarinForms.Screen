using UIKit;

namespace XamarinForms.Screen
{
    /// <summary>
    /// get the native screen dimension of the current ios device
    /// </summary>
    public static partial class ScreenSize
    {
        /// <summary>
        /// get screen width for ios devices
        /// </summary>
        /// <returns>the screen width as double</returns>
        static double GetNativeWidth() => UIScreen.MainScreen.Bounds.Height;

        /// <summary>
        /// get screen height for ios devices
        /// </summary>
        /// <returns>the screen heighr as double</returns>
        static double GetNativeHeight() => UIScreen.MainScreen.Bounds.Width;
    }
}
