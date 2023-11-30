using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonPrefixes
{
    /// <summary>
    /// Static class for finding prefixes within a list of strings using a given delimiter.
    /// </summary>
    public static class PrefixesFinder
    {
        #region Public-Members

        #endregion

        #region Private-Members

        #endregion

        #region Public-Methods

        /// <summary>
        /// Generate a list of common prefixes found within a supplied list of strings and a given delimiter character.
        /// </summary>
        /// <param name="vals">List of strings.</param>
        /// <param name="delimiter">Delimiter character.</param>
        /// <returns>List of strings.</returns>
        public static List<string> Find(List<string> vals, char delimiter)
        {
            if (vals == null || vals.Count < 1) return new List<string>();

            List<string> ret = new List<string>();

            foreach (string val in vals)
            {
                if (String.IsNullOrEmpty(val)) continue;

                string[] split = val.Split(delimiter);
                if (split != null && split.Length > 1)
                {
                    string prefix = string.Empty;

                    for (int i = 0; i < (split.Length - 1); i++)
                    {
                        prefix += split[i] + delimiter;
                    }

                    ret.Add(prefix);
                }
            }

            return ret.Distinct().ToList();
        }

        /// <summary>
        /// Generate a list of common prefixes found within a supplied list of strings and a given delimiter character.
        /// </summary>
        /// <param name="vals">List of strings.</param>
        /// <param name="delimiter">Delimiter string.</param>
        /// <returns>List of strings.</returns>
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public static List<string> Find(List<string> vals, string? delimiter)
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        {
            if (vals == null || vals.Count < 1) return new List<string>();

            List<string> ret = new List<string>();

            foreach (string val in vals)
            {
                if (String.IsNullOrEmpty(val)) continue;

                string[] split = val.Split(delimiter);
                if (split != null && split.Length > 1)
                {
                    string prefix = string.Empty;

                    for (int i = 0; i < (split.Length - 1); i++)
                    {
                        prefix += split[i] + delimiter;
                    }

                    ret.Add(prefix);
                }
            }

            return ret.Distinct().ToList();
        }

        #endregion

        #region Private-Methods

        #endregion
    }
}