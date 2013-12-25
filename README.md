# Sentinel Gallery

Sentinel is developed by [György Balássy](http://gyorgybalassy.wordpress.com) to create the simplest photo gallery that supports super-easy image publishing. 

If you have any comments, questions, tips or ideas, do not hesitate to contact me via e-mail (balassy at aut.bme.hu) or Twitter ([@gyorgybalassy](http://twitter.com/gyorgybalassy)).



## Features


### Simple publishing

Just create a separate folder for each of your galleries in the `Photos` folder, and then add your JPG and PNG images to it.
Sentinel will automatically list the folders as galleries, and displays the image files in them.

You can add new galleries any time without recompiling and republishing the website. Create a new folder, add your images to it and you are done!

You can change the default folder which contains the galleries in the `web.config` file.

    <Sentinel>
        <Galleries storageFolderVirtualPath="~/Photos" />
    </Sentinel>


### Gallery thumbnails

When a gallery folder contains a `folder.jpg` file, Sentinel uses it as the thumbnail image for the gallery (just like in Windows Explorer).

If there is no `folder.jpg` file in the gallery folder, then the first image is used as the thumbnail.


### Localization

Sentinel supports multiple display languages. By default the site is displayed in English, but if the client requests another display language and localization is available, then Sentinel will display localized texts.

Currently only Hungarian localization is provided, but you can add support for new languages by translating the `.resx` files in the `Resources` folder.

Sentinel relies on the language detection mechanism of ASP.NET to select the display language. To turn of automatic language detection and force a selected language, modify te `web.config` file:

    <globalization culture="auto" uiCulture="auto" ... />


## Installation

Build and publish the source code. The default login password is `demo`. You can change it in the following section in the `web.config` file by setting the SHA1 hash of your desired password:

    <user name="demo" password="89e495e7941cf9e40e6980d14a16bf023ccd4c91" /> 



## Technology showcase

Sentinel is built using the following technologies:

* Server-side:
	* ASP.NET MVC 5
	* ASP.NET Bundling and minification 
	* Compiled MVC views
	* Code contracts
	* Custom configuration handlers
	* Localization
	* T4MVC
	* Ninject for dependency injection

* Client-side:
	* Bootstrap
	* LESS
	* jQuery
	* jQuery Validate
	

## Licensing

You are free to use this source code for anything you want, however please note that the code is provided as-is, without any warranty or support.

If you like or use this project, please be so kind and drop me a message about it. 


## About the author

**György Balássy** is a software architect, speaker, author, teacher, ethical hacker from Budapest, Hungary. You can reach and follow him via his [blog](http://gyorgybalassy.wordpress.com) or his [@gyorgybalassy](http://twitter.com/gyorgybalassy) Twitter page.

