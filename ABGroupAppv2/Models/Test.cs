using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.JavaScript;

namespace ABGroupAppv2
{
    public static class FileUtil
    {
        public async static Task SaveAs(IJSRuntime js, string filename, byte[] data)
        {
            await js.InvokeAsync<object>(
                "SaveAsFile",
                filename,
                Convert.ToBase64String(data));
        }
    }
}
