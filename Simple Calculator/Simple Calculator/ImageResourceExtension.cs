﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simple_Calculator
{
    [ContentProperty(nameof(Source))]
    class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(Source == null)
            {
                return null;
            }
            
            var imagesource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imagesource;
        }
    }
}
