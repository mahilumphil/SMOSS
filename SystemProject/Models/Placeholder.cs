using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace SystemProject.Models
{
    class PlaceholderAttribute : Attribute
    {
        public class PlaceHolderAttribute : Attribute, IMetadataAware
        {
            private readonly string _placeholder;
            public PlaceHolderAttribute(string placeholder)
            {
                _placeholder = placeholder;
            }

            public void OnMetadataCreated(ModelMetadata metadata)
            {
                metadata.AdditionalValues["placeholder"] = _placeholder;
            }
        }
    }
}
