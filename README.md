# Sentinel Gallery

Sentinel aims to be simplest photo gallery that supports super-easy image publishing. 

## Features

### Simple publishing

Just create a separate folder for each of your galleries in the `Photos` folder, and then add your JPG and PNG images to it.
Sentinel will automatically list the folders as galleries, and displays the image files in them.

You can change the default folder which contains the galleries in the `web.config` file:

    &lt;Sentinel&gt;
        &lt;Galleries storageFolderVirtualPath="~/Photos" /&gt;
    &lt;/Sentinel&gt;

## Gallery thumbnails

When a gallery folder contains a `folder.jpg` file, Sentinel uses it as the thumbnail image for the gallery (just like in Windows Explorer).

If there is no `folder.jpg` file in the gallery folder, then the first image is used as the thumbnail.

## Localization

Sentinel supports multiple display languages.


## Technology showcase

Sentinel is built using the following technologies:

* Server-side:
	* ASP.NET MVC 5
	* Compiled MVC views
	* Custom configuration handlers
	* Localization
	* T4MVC
	* Ninject for dependency injection

* Client-side:
	* Bootstrap
	* LESS
	* jQuery
	* jQuery Validate
	* ASP.NET bundling and minification

