﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace FOSSTRAK.TDT
{
    /// <summary>
    /// Contains methods to assist with parsing one value into another.
    /// </summary>
    public static class ParseAssistant
    {
        #region TryParse Overloads
        /// <summary>
        /// Attempts to parse the string provided into an integer value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out int result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToInt32(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = int.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a byte value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out byte result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToByte(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = byte.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into an Int16 value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out Int16 result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToInt16(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = Int16.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into an Int64 value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out Int64 result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToInt64(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = Int64.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a decimal value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out decimal result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToDecimal(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = decimal.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a float value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out float result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = (float)Convert.ToDecimal(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = float.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a double value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out double result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToDouble(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = double.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into an sbyte value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out sbyte result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = (sbyte)Convert.ToInt32(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = sbyte.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a uint value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out uint result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = (uint)Convert.ToUInt64(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = uint.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a ulong value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out ulong result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = (ulong)Convert.ToUInt64(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = ulong.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into a ushort value. 
        /// </summary>
        /// <remarks>Returns 0 in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or zero if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out ushort result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = (ushort)Convert.ToUInt64(s);
                retVal = true;
            }
            catch (FormatException) { result = 0; }
            catch (InvalidCastException) { result = 0; }
#else
            retVal = ushort.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into an <see cref="System.DateTime"/> value. 
        /// </summary>
        /// <remarks>Returns <see cref="System.DateTime.MinValue"/> in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or <see cref="System.DateTime.MinValue"/> if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out DateTime result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToDateTime(s);
                retVal = true;
            }
            catch (FormatException) { result = DateTime.MinValue; }
            catch (InvalidCastException) { result = DateTime.MinValue; }
#else
            retVal = DateTime.TryParse(s, out result);
#endif
            return retVal;
        }

        /// <summary>
        /// Attempts to parse the string provided into an integer value. 
        /// </summary>
        /// <remarks>Returns false in the result parameter if the parse fails.</remarks>
        /// <param name="s">The string to attempt to parse.</param>
        /// <param name="result">The result of the parsed string, or false if parsing failed.</param>
        /// <returns>A boolean value indicating whether or not the parse succeeded.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "s")]
        public static bool TryParse(string s, out bool result)
        {
            bool retVal = false;
#if PocketPC
            try
            {
                result = Convert.ToBoolean(s);
                retVal = true;
            }
            catch (FormatException) { result = false; }
            catch (InvalidCastException) { result = false; }
#else
            retVal = bool.TryParse(s, out result);
#endif
            return retVal;
        }
        #endregion
    }
    
    public static class EnumHelper  
    {
        public static bool TryParse<TEnum>(string value, bool ignoreCase, ref TEnum result) where TEnum : struct
        {
            bool parsed = false;
            try
            {
                result = (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
                parsed = true;
            }
            catch { }
            return parsed;
        }

        public static bool TryParse<TEnum>(string value, ref TEnum result) where TEnum : struct
        {
            bool ignoreCase = true;
            bool parsed = false;
            try
            {
                result = (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
                parsed = true;
            }
            catch { }
            return parsed;
        }

        public static string[] GetNames(Type enumType)
        {
            FieldInfo[] fieldInfo = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            return fieldInfo.Select(f => f.Name).ToArray();
        }
    }  
}
