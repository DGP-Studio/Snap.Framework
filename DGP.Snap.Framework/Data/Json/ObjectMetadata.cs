﻿using System;
using System.Collections.Generic;

namespace DGP.Snap.Framework.Data.Json
{
    internal struct ObjectMetadata
    {
        private Type element_type;
        private bool is_dictionary;

        private IDictionary<string, PropertyMetadata> properties;


        public Type ElementType
        {
            get
            {
                if (this.element_type == null)
                    return typeof(JsonData);

                return this.element_type;
            }

            set => this.element_type = value;
        }

        public bool IsDictionary
        {
            get => this.is_dictionary;
            set => this.is_dictionary = value;
        }

        public IDictionary<string, PropertyMetadata> Properties
        {
            get => this.properties;
            set => this.properties = value;
        }
    }
}