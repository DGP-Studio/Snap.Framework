﻿using System;

namespace DGP.Snap.Framework.Net.Web.QueryString
{
    /// <summary>
    /// A single query string parameter (name and value pair).
    /// </summary>
    public sealed class QueryStringParameter
    {
        private string _name;

        /// <summary>
        /// The name of the parameter. Cannot be null.
        /// </summary>
        public string Name
        {
            get => this._name;
            set => this._name = value ?? throw new ArgumentNullException("Name");
        }

        /// <summary>
        /// The value of the parameter (or null if there's no value).
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Initializes a new query string parameter with the specified name and optional value.
        /// </summary>
        /// <param name="name">The name of the parameter. Cannot be null.</param>
        /// <param name="value">The optional value of the parameter.</param>
        internal QueryStringParameter(string name, string value = null)
        {
            this.Name = name ?? throw new ArgumentNullException("name");
            this.Value = value;
        }
    }
}
