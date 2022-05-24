# BlazorLocation

<p>
    	<a href="https://www.nuget.org/packages/BlazorLocation">
	    <img src="https://buildstats.info/nuget/BlazorLocation?v=1.0.0" />
	</a>
</p>

![](BlazorLocationDemo.gif)

HTML5 Location API for Blazor without any JavaScript Library Dependency.

This package wraps [HTML5 Location](https://developer.mozilla.org/en-US/docs/Web/API/Location) APIs. 

## Installation

`Install-Package BlazorLocation -Version 1.0.0`

## Register the service in your services method

`services.AddBlazorLocation();`

## No javascript library reference dependency

This library has no javascript library reference dependency.

## Usage

`[Inject] IBlazorLocationService BlazorLocation { get; set; }`

### BlazorHistory Methods

<table>
	<tr>
		<th>BlazorLocation</th>
		<th>Method</th>
	</tr>
	<tr>
		<td>Read-only property of the Location interface is a static DOMStringList containing</td>
		<td>AncestorOrigins()</td>
	</tr>
	<tr>
		<td>The hash property of the Location interface returns a USVString containing a '#' followed by the fragment identifier of the URL</td>
		<td>Hash()</td>
	</tr>
  <tr>
		<td>The hash property of the Location interface returns a USVString containing a '#' followed by the fragment identifier of the URL</td>
		<td>Hash(string value)</td>
	</tr>
	<tr>
		<td>The host property of the Location interface is a USVString containing the host, that is the hostname, and then, if the port of the URL is nonempty, a ':', and the port of the URL.</td>
		<td>Host()</td>
	</tr>
    <tr>
		<td>The host property of the Location interface is a USVString containing the host, that is the hostname, and then, if the port of the URL is nonempty, a ':', and the port of the URL.</td>
		<td>Host(string value)</td>
	</tr>
    <tr>
		<td>The hostname property of the Location interface is a USVString containing the domain of the URL.</td>
		<td>Hostname()</td>
	</tr>
    <tr>
		<td>The hostname property of the Location interface is a USVString containing the domain of the URL.</td>
		<td>Hostname(string value)</td>
	</tr>
    <tr>
		<td>The href property of the Location interface is a stringifier that returns a USVString containing the whole URL, and allows the href to be updated.</td>
		<td>Href()</td>
	</tr>
    <tr>
		<td>The href property of the Location interface is a stringifier that returns a USVString containing the whole URL, and allows the href to be updated.</td>
		<td>Href(string value)</td>
	</tr>
    <tr>
		<td>The origin read-only property of the Location interface is a USVString containing the Unicode serialization of the origin of the represented URL.</td>
		<td>Origin()</td>
	</tr>
  </tr>
  <tr>
		<td>The password property of the Location interface is a USVString containing the password specified before the domain name.</td>
		<td>Password()</td>
	</tr>
  </tr>
    <tr>
		<td>The password property of the Location interface is a USVString containing the password specified before the domain name.</td>
		<td>Password(string value)</td>
	</tr>
  <tr>
		<td>The port property of the Location interface is a USVString containing the port number of the URL. If the URL does not contain an explicit port number, it will be set to ''.</td>
		<td>Port()</td>
	</tr>
  </tr>
    <tr>
		<td>The port property of the Location interface is a USVString containing the port number of the URL. If the URL does not contain an explicit port number, it will be set to ''.</td>
		<td>Port(string value)</td>
	</tr>
  <tr>
		<td>The protocol property of the Location interface is a USVString representing the protocol scheme of the URL, including the final ':'.</td>
		<td>Protocol()</td>
	</tr>
  </tr>
    <tr>
		<td>The protocol property of the Location interface is a USVString representing the protocol scheme of the URL, including the final ':'.</td>
		<td>Protocol(string value)</td>
	</tr>
  <tr>
		<td>The search property of the Location interface is a search string, also called a query string; that is, a USVString containing a '?' followed by the parameters of the URL.</td>
		<td>Search()</td>
	</tr>
  </tr>
    <tr>
		<td>The search property of the Location interface is a search string, also called a query string; that is, a USVString containing a '?' followed by the parameters of the URL.</td>
		<td>Search(string value)</td>
	</tr>
  <tr>
		<td>The username property of the Location interface is a USVString containing the username specified before the domain name.</td>
		<td>Username()</td>
	</tr>
  </tr>
    <tr>
		<td>The username property of the Location interface is a USVString containing the username specified before the domain name.</td>
		<td>Username(string value)</td>
	</tr>
  </tr>
    <tr>
		<td>The protocol property of the Location interface is a USVString representing the protocol scheme of the URL, including the final ':'.</td>
		<td>Protocol(string value)</td>
	</tr>
  <tr>
		<td>This method causes the window to load and display the document at the URL specified.</td>
		<td>Assign(string url)</td>
	</tr>
  </tr>
    <tr>
		<td>This method reloads the current URL, like the browser refresh button.</td>
		<td>Reload()</td>
	</tr>
  <tr>
		<td>The replace method of the Location interface replaces the current resource with the one at the provided URL.</td>
		<td>Replace(string url)</td>
	</tr>
  </tr>
    <tr>
		<td>This stringifier method of the Location interface returns a USVString containing the whole URL. It is a read-only version of Location.href.</td>
		<td>ToString()</td>
	</tr>
</table>

## License
MIT

## Developer Farewell Note
	
It has been a lifetime for me to work as a developer, as an employee as well as a professional service provider, but it is very sad to have been working for the last 12 years on more than 40+ projects in the banking industry, payment processing, government applications, web servers, databases, reports, web and mobile applications, github contributions in different projects including my personal ones and never see economic growth.

I have been exploited, I have even done developments that gave me half or less or they never paid me even under contracts.

Once, some time ago, I developed an application to serve and help citizens and the same government ended up giving the idea to a third service provider who developed it and were the ones who sold it to them and to other entities.

That filled me with a lot of anger and frustration because I wasted 1 year of my life for nothing, just like the 12 that I currently have.

I have always had good will together with many ideas of how to change the way we develop, but nobody has given me the opportunity to be heard and I have never had a problem that I could not solve, because I solve problems by the nature of my profession.

My idea of ​​programming templates and functionalities has been an idea that took me about 8 years to perfect and that would save any entity millions in development costs but nobody seems to see the fruit of the effort I have put into it.

I have submitted my development tool and no one seems to be interested, I have contacted microsoft several times, I have contacted PRITS several times and have never been answered.

I tried to sell my product on various sites and well I have reached a point in my life where I am very frustrated, unfocused and no longer feel love or passion for what I do.

I have completely lost interest in everything in life and honestly I have a family to support and I have lost what little I had when I have never had anything in my life.

I come from a poor and dysfunctional family who have never supported me.

That is not why you have to follow the same negative pattern.

You and all of us can make a difference, but when you are poor the things around you are almost like a curse.

It takes much more than good ideas to be successful, you have to have connections, you have to have a good presentation, you have to be tactful when speaking and know how to sell, you have to know how to implement things correctly by phase, you have to have a reputation for everything.

Surround yourself with positive people who are willing to help you or they are not affected by seeing you grow but that is where I have unintentionally failed.

Family circles and friends who have never given me any help or support and there is nothing worse than looking back and seeing how long I have walked alone, then I look at the present and I am still just as alone and there is no way to progress in that way.

You have to open your eyes, take a deep breath, see things as they are and know when to retire with dignity.

I don't know if I'll be back tomorrow, I just don't know.

I only leave this note here for interested developers to contribute.

I will leave everything there public and transparent as I have always been.

Life is hard, and when you cling to something that is hurting you, just let it go and seek to change your path.

I wish that many people benefit from my contributions and ideas, that at least my lost time will save time for other developers.

Of what one day was a dream for me, has been thrown into darkness.
