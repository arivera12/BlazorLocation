using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BlazorLocation
{
    internal class BlazorLocationService : IBlazorLocationService
    {
        private readonly IJSRuntime JSRuntime;
        public BlazorLocationService(IJSRuntime jSRuntime)
        {
            JSRuntime = jSRuntime;
        }
        public async ValueTask<IDomStringList> AncestorOrigins()
        {
            return JsonConvert.DeserializeObject<DomStringList>(JsonConvert.SerializeObject(await JSRuntime.InvokeAsync<object>("eval", "window.location.ancestorOrigins")));
        }
        public ValueTask Assign(string url)
        {
            return JSRuntime.InvokeVoidAsync("window.location.assign", url);
        }
        public ValueTask<string> Hash()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.hash");
        }
        public ValueTask Hash(string value)
        {
            return JSRuntime.InvokeVoidAsync("eval", $"window.location.hash = '{value}'");
        }
        public ValueTask<string> Host()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.host");
        }
        public ValueTask<string> Host(string value)
        {
            return JSRuntime.InvokeAsync<string>("eval", $"window.location.host = '{value}'");
        }
        public ValueTask<string> Hostname()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.hostname");
        }
        public ValueTask<string> Hostname(string value)
        {
            return JSRuntime.InvokeAsync<string>("eval", $"window.location.hostname = '{value}'");
        }
        public ValueTask<string> Href()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.href");
        }
        public ValueTask Href(string value)
        {
            return JSRuntime.InvokeVoidAsync("eval", $"window.location.href = '{value}'");
        }
        public ValueTask<string> Origin()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.origin");
        }
        public ValueTask<string> Password()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.password");
        }
        public ValueTask Password(string value)
        {
            return JSRuntime.InvokeVoidAsync("eval", $"window.location.password = '{value}'");
        }
        public ValueTask<string> Pathname()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.pathname");
        }
        public ValueTask<string> Pathname(string path)
        {
            return JSRuntime.InvokeAsync<string>("eval", $"window.location.pathname = '{path}'");
        }
        public ValueTask<string> Port()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.port");
        }
        public ValueTask<string> Port(string value)
        {
            return JSRuntime.InvokeAsync<string>("eval", $"window.location.port = '{value}'");
        }
        public ValueTask<string> Protocol()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.protocol");
        }
        public ValueTask<string> Protocol(string value)
        {
            return JSRuntime.InvokeAsync<string>("eval", $"window.location.protocol = '{value}'");
        }
        public ValueTask Reload()
        {
            return JSRuntime.InvokeVoidAsync("window.location.reload");
        }
        public ValueTask Replace(string url)
        {
            return JSRuntime.InvokeVoidAsync("window.location.replace", url);
        }
        public ValueTask<string> Search()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.search");
        }
        public ValueTask Search(string value)
        {
            return JSRuntime.InvokeVoidAsync("eval", $"window.location.search = '{value}'");
        }
        ValueTask<string> IBlazorLocationService.ToString()
        {
            return JSRuntime.InvokeAsync<string>("window.location.toString");
        }
        public ValueTask<string> Username()
        {
            return JSRuntime.InvokeAsync<string>("eval", "window.location.username");
        }
        public ValueTask Username(string value)
        {
            return JSRuntime.InvokeVoidAsync("eval", $"window.location.username = '{value}'");
        }
    }
}
