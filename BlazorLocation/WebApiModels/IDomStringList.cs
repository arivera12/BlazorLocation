using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorLocation
{
    /// <summary>
    /// A type returned by some APIs which contains a list of DOMString (strings)
    /// </summary>
    public interface IDomStringList
    {
        /// <summary>
        /// Returns the length of the list.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        int Length { get; set; }
        /// <summary>
        /// Returns boolean indicating if the given string is in the list.
        /// </summary>
        /// <param name="searchTerm">The search term to find</param>
        /// <returns></returns>
        ValueTask<bool> Contains(string searchTerm);
        /// <summary>
        /// Returns a DOMString by index.
        /// </summary>
        /// <param name="index">The index of the item</param>
        /// <returns></returns>
        ValueTask<string> Item(int index);
    }
}
