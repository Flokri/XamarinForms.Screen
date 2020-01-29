namespace XamarinForms.Screen
{
    /// <summary>
    /// get the native screen dimension of the current android device
    /// </summary>
    public static partial class ScreenSize
    {
        /// <summary>
        /// get screen width for android devices
        /// </summary>
        /// <returns>the screen width as double</returns>
        static double GetNativeWidth() => 
            Android.App.Application.Context.Resources.DisplayMetrics.HeightPixels / (double)Android.App.Application.Context.Resources.DisplayMetrics.Density;

        /// <summary>
        /// get screen height for android devices
        /// </summary>
        /// <returns>the screen heighr as double</returns>
        static double GetNativeHeight() =>
            Android.App.Application.Context.Resources.DisplayMetrics.WidthPixels / (double)Android.App.Application.Context.Resources.DisplayMetrics.Density;
    }
}
