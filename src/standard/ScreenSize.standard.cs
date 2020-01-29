using System;

namespace XamarinForms.Screen
{
    /// <summary>
    /// not implemented for .netstandard
    /// </summary>
    public static partial class ScreenSize
    {
        static double GetNativeWidth() =>
            throw new NotImplementedException("This function is not implemented for .netstandard.");
        
        static double GetNativeHeight() =>
            throw new NotImplementedException("This function is not implemented for .netstandard.");
    }
}
