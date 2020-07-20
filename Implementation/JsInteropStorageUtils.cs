﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUtils.JsInterop
{
    internal class JsInteropStorageUtils : IJsInteropStorageUtils
    {
        private IJSRuntime _jsr;
        internal JsInteropStorageUtils(IJSRuntime jsr)
        {
            _jsr = jsr;
        }

        public async Task<string> LocalStorageGetItem(string key)
        {
            return await _jsr.InvokeAsync<string>("localStorage.getItem", key);
        }

        public async Task<string> LocalStorageSetItem(string key, string value)
        {
            return await _jsr.InvokeAsync<string>("localStorage.setItem", key, value);
        }
    }
}