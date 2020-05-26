using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BlazorLocation
{
    internal class DomStringList : IDomStringList
    {
        private readonly IJSRuntime JsRuntime;
        public DomStringList()
        {

        }
        public DomStringList(IJSRuntime jSRuntime)
        {
            JsRuntime = jSRuntime;
        }
        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }
        public ValueTask<bool> Contains(string searchTerm)
        {
            return JsRuntime.InvokeAsync<bool>("window.location.ancestorOrigins.contains", searchTerm);
        }
        public ValueTask<string> Item(int index)
        {
            return JsRuntime.InvokeAsync<string>("window.location.ancestorOrigins.item", index);
        }
    }
}
