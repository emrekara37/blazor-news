using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp.Pages
{
    public class IndexComponentBase:ComponentBase
    {
        [Inject]
        protected IJSRuntime JsRuntime { get; set; }
        protected override async  Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeVoidAsync("initHome");
            }
        }
    }
}