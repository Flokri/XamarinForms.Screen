namespace XamarinForms.Screen
{
    /// <summary>
    /// get the native screen dimension of the current device
    /// </summary>
    public static partial class ScreenSize
    {
        /// <summary>
        /// get the native screen width
        /// </summary>
        /// <returns>the native screen width as double</returns>
        public static double GetScreenWidth() => GetNativeWidth();

        /// <summary>
        /// get the native screen height
        /// </summary>
        /// <returns>the native screen height as double</returns>
        public static double GetScreenHeight() => GetNativeHeight();
    }
}
