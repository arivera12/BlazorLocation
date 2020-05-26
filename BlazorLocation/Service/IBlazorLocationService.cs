using System;
using System.Threading.Tasks;

namespace BlazorLocation
{
    /// <summary>
    /// The Location interface represents the location (URL) of the object it is linked to. 
    /// Changes done on it are reflected on the object it relates to. 
    /// Both the Document and Window interface have such a linked Location, accessible via Document.location and Window.location respectively.
    /// </summary>
    public interface IBlazorLocationService
    {
        /// <summary>
        /// Read-only property of the Location interface is a static DOMStringList containing, in reverse order, 
        /// the origins of all ancestor browsing contexts of the document associated with the given Location object.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        ValueTask<IDomStringList> AncestorOrigins();
        /// <summary>
        /// The hash property of the Location interface returns a USVString containing a '#' followed by the fragment identifier of the URL, and allows the hash to be updated.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Hash();
        /// <summary>
        /// The hash property of the Location interface returns a USVString containing a '#' followed by the fragment identifier of the URL, and allows the hash to be updated.
        /// </summary>
        /// <param name="value">The hash value</param>
        /// <returns></returns>
        ValueTask Hash(string value);
        /// <summary>
        /// The host property of the Location interface is a USVString containing the host, that is the hostname, and then, if the port of the URL is nonempty, a ':', and the port of the URL.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Host();
        /// <summary>
        /// The host property of the Location interface is a USVString containing the host, that is the hostname, and then, if the port of the URL is nonempty, a ':', and the port of the URL.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Host(string value);
        /// <summary>
        /// The hostname property of the Location interface is a USVString containing the domain of the URL.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Hostname();
        /// <summary>
        /// The hostname property of the Location interface is a USVString containing the domain of the URL.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Hostname(string value);
        /// <summary>
        /// The href property of the Location interface is a stringifier that returns a USVString containing the whole URL, and allows the href to be updated.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Href();
        /// <summary>
        /// The href property of the Location interface is a stringifier that returns a USVString containing the whole URL, and allows the href to be updated.
        /// </summary>
        /// <param name="value">The href value</param>
        /// <returns></returns>
        ValueTask Href(string value);
        /// <summary>
        /// The origin read-only property of the Location interface is a USVString containing the Unicode serialization of the origin of the represented URL.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Origin();
        /// <summary>
        /// The password property of the Location interface is a USVString containing the password specified before the domain name.
        /// </summary>
        /// <returns></returns>
        [Obsolete("This feature is obsolete. Although it may still work in some browsers, its use is discouraged since it could be removed at any time. Try to avoid using it.")]
        ValueTask<string> Password();
        /// <summary>
        /// The password property of the Location interface is a USVString containing the password specified before the domain name.
        /// </summary>
        /// <param name="value">The password value</param>
        /// <returns></returns>
        [Obsolete("This feature is obsolete. Although it may still work in some browsers, its use is discouraged since it could be removed at any time. Try to avoid using it.")]
        ValueTask Password(string value);
        /// <summary>
        /// The pathname property of the Location interface is a USVString containing an initial '/' followed by the path of the URL (or the empty string if there is no path).
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Pathname();
        /// <summary>
        /// The pathname property of the Location interface is a USVString containing an initial '/' followed by the path of the URL (or the empty string if there is no path).
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        ValueTask<string> Pathname(string path);
        /// <summary>
        /// The port property of the Location interface is a USVString containing the port number of the URL. If the URL does not contain an explicit port number, it will be set to ''.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Port();
        /// <summary>
        /// The port property of the Location interface is a USVString containing the port number of the URL. If the URL does not contain an explicit port number, it will be set to ''.
        /// </summary>
        /// <param name="value">The port value</param>
        /// <returns></returns>
        ValueTask<string> Port(string value);
        /// <summary>
        /// The protocol property of the Location interface is a USVString representing the protocol scheme of the URL, including the final ':'.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Protocol();
        /// <summary>
        /// The protocol property of the Location interface is a USVString representing the protocol scheme of the URL, including the final ':'.
        /// </summary>
        /// <param name="value">The protocol value</param>
        /// <returns></returns>
        ValueTask<string> Protocol(string value);
        /// <summary>
        /// The search property of the Location interface is a search string, also called a query string; that is, a USVString containing a '?' followed by the parameters of the URL.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> Search();
        /// <summary>
        /// The search property of the Location interface is a search string, also called a query string; that is, a USVString containing a '?' followed by the parameters of the URL.
        /// </summary>
        /// <param name="value">The search value</param>
        /// <returns></returns>
        ValueTask Search(string value);
        /// <summary>
        /// The username property of the Location interface is a USVString containing the username specified before the domain name.
        /// </summary>
        /// <returns></returns>
        [Obsolete("This feature is obsolete. Although it may still work in some browsers, its use is discouraged since it could be removed at any time. Try to avoid using it.")]
        ValueTask<string> Username();
        /// <summary>
        /// The username property of the Location interface is a USVString containing the username specified before the domain name.
        /// </summary>
        /// <param name="value">The username value</param>
        /// <returns></returns>
        [Obsolete("This feature is obsolete. Although it may still work in some browsers, its use is discouraged since it could be removed at any time. Try to avoid using it.")]
        ValueTask Username(string value);
        /// <summary>
        /// This method causes the window to load and display the document at the URL specified.
        /// </summary>
        /// <param name="url">The url value</param>
        /// <returns></returns>
        ValueTask Assign(string url);
        /// <summary>
        /// This method reloads the current URL, like the browser refresh button.
        /// </summary>
        /// <returns></returns>
        ValueTask Reload();
        /// <summary>
        /// The replace method of the Location interface replaces the current resource with the one at the provided URL.
        /// </summary>
        /// <param name="url">The url value</param>
        /// <returns></returns>
        ValueTask Replace(string url);
        /// <summary>
        ///This stringifier method of the Location interface returns a USVString containing the whole URL. It is a read-only version of Location.href.
        /// </summary>
        /// <returns></returns>
        ValueTask<string> ToString();
    }
}
