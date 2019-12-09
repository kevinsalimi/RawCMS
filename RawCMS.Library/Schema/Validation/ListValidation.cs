﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************

namespace RawCMS.Library.Schema.Validation
{
    public class ListValidation : BaseJavascriptValidator
    {
        public override string Type => "list";

        public override string Javascript
        {
            get
            {
                return @"

var debug=""debug""+JSON.stringify(options);
if(options.allownotmapped == undefined || options.allownotmapped ===""false"" ) {

    
    var regExp= new RegExp(""(\|X=([^\|]*)\|)|(\|X\|)"".replace(/X/gm,value));
    log(regExp);
    var result= (""|""+options[""items""]+""|"").toString().match(regExp);

log(result);
    if(result==null)
    {
      errors.push({""Code"":""LIST-01"", ""Title"":""value not allowed""});
    }
}
var backendResult=JSON.stringify(errors);

            ";
            }
        }
    }
}