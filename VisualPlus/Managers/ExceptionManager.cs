﻿namespace VisualPlus.Managers
{
    #region Namespace

    using System;

    #endregion

    internal class ExceptionManager
    {
        #region Events

        /// <summary>Returns a bool indicating whether the value is in range.</summary>
        /// <param name="sourceValue">The main value.</param>
        /// <param name="minimumValue">Minimum value.</param>
        /// <param name="maximumValue">Maximum value.</param>
        /// <param name="round">Round to nearest value when out of range.</param>
        /// <returns>Bool value.</returns>
        public static int ArgumentOutOfRangeException(int sourceValue, int minimumValue, int maximumValue, bool round)
        {
            if ((sourceValue >= minimumValue) && (sourceValue <= maximumValue))
            {
                return sourceValue;
            }
            else
            {
                if (round)
                {
                    return MathManager.FindClosestValue(sourceValue, new[] { minimumValue, maximumValue });
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The value (" + sourceValue + ") must be in range of " + minimumValue + " to " + maximumValue + ".");
                }
            }
        }

        #endregion
    }
}