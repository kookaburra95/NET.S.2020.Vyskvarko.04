using System;
using System.Collections;

namespace DoubleToBinary
{
    /// <summary>
    /// This is a class extension for type Double.
    /// </summary>
    public static class DoubleExtension
    {
        /// <summary>
        /// This method converts a double precision real number into a string with its binary representation.
        /// </summary>
        /// <param name="number">Double number for convert.</param>
        /// <returns>String with its binary representation.</returns>
        public static string ToBinaryString(this Double number)
        {
            var bitArray = new BitArray(BitConverter.GetBytes(number));
            var result = "";

            for (var i = bitArray.Length - 1; i >= 0; i--)
            {
                if (bitArray[i])
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }

            return result;
        }
    }
}
