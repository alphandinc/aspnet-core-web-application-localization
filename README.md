Basic .NET Core MVC Web Application Localization

It is my first post :) and I would like to give an example basic need for a web application which is localization. 

There are several example usage for this implementation furthermore I try to keep this repo simple and this way is the easiest way to develop and use for me. 
I will try to visualize the steps. If there is a misatake in the writing, please forgive me. Let's start…
First we choose the application type in Visual Studio (I use 2019 version).

Choose the ASP.NET Core Web Applcation from Create New Project option.

After we choose, we will set the applcation name and locaiton on local computer.

Last step to configure new application is choose template, 
I use MVC (Model-View-Controller) for this example which installs the necessary packeages and structure in solution explorer. 
After you create the application you may remove the unnecessary packages which you think. 
Here we set the .NET Core version is 3.1.

So, we have created the application, 
you may run(F5) for the first and can bu sure everyhing is ok up to now. 

Now we start to implment localization feature for our app. 
First step is overriding Startup.cs with using localization libraries of AspNetCore. 
In ConfigureServices method, set up the cookie policy options, 
determine the resources path for translations and languages list which can be used and default language for our application.

In the second method of Startup.cs is Configure, localization options have been added to app interface which is used as build application.

Now, we can create our resource files which we need as language opitons. 
Here .NET Core has a structure for resource files (.resx). 
It belongs to application views folder structure. We use country codes for resource file as in attached picture below.

After adding files, we need to insert the tranlations for the localization keys.

In addition to these implmentation, in index.cshtml file we add the country flags to use change language click on UI side.

We also need to inject localization class to cshtml file so we can call the localization key. 
As in the previous picture, you may see the key name Welcome, you see the same key parameter with _localizer object in below attachment.

There is written ajax post request script to call the backend method (Home controller, 
SetLanguage method) to change the language from UI side. 
We pass the culture code which we named the resource file before and this parameter comes from the id attribute of img control on index.cshtml file. 
You may use other attributes if you need. We set window.location to / (same page) because we must keep the existing page, a little workaround here. 

At the end of our task we implement the backend post method (SetLanguage). 
Method gets the parameter culture code which we pass with ajax request. There is a favor for end-user which can save the selected language option in time period which we set in cookie, in this example language have been set in cookie for 1 day.

Eventually we have localization in our application with a little effort :) hope it helps who need to use. 
If you have any question, please do not hesitate to ask. See you soon ;) 
