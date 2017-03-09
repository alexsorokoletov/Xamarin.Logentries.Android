# Logentries SDK for Xamarin.Android
[![NuGet Badge](https://buildstats.info/nuget/Xamarin.Logentries.Android?includePreReleases=true)](https://www.nuget.org/packages/Xamarin.Logentries.Android/)

This is a Xamarin Android bindings for Logentries le_android static library
[le_android](https://github.com/logentries/le_android)

[Logentries for Android features](https://github.com/LogentriesCommunity/le_android#features):
-------------

- Log events are forwarded over TCP to a specific log

	A unique Token UUID for the log is appended to each log event that is sent

- Send Logs via SSL (only available with the TCP Token method)

	The library can send logs via Token TCP over TLS/SSL to port 443

	Note that the library itself does not validate or manage TLS/SSL certificates!

- Storing logs offline and sending when connected.  

	While sending logs, if the device looses connection, logs are stored locally until a connection is reestablished

	10mb queue limit

- TraceID

	Each log event sent contains the device TraceID which is a unique 35 character ID.

- Datahub support

	Log events can be forward by TCP Token to Datahub

- Send Logs via HTTP POST (Note that this option will be deprecated in the near future!)

	Option of changing from Token TCP to using HTTP POST sending to the endpoint 'http://js.logentries.com/v1/logs/LOG-TOKEN'

	It is recommended to use the Token TCP default, which also has the option of using TLS/SSL

Installation
------------

Install NuGet package: `Install-Package Xamarin.Logentries.Android`.

Add the permission "android.permission.INTERNET" to the project manifest file.

If you don't have a Logentries account yet, go ahead and create free account using this link: [https://logentries.com/learnmore?code=781f627c](https://logentries.com/learnmore?code=781f627c)

_Note: this is a referral link. Using it will help to grow my logging limits. Here is a plain url [https://logentries.com/](https://logentries.com/)_

Simple example
--------------

```
using Logentries.Android;
...
var logger = AndroidLogger.CreateInstance(Android.AndroidApplication.Context.ApplicationContext,
                                          false, true, false, null, 0, "{YOUR TOKEN HERE}", true);
logger.Log("MyActivity has been created");
```

or 

```
using Logentries.Android;
...
var logger = AndroidLogger.CreateInstance("{YOUR TOKEN HERE}");
logger.Log("MyActivity has been created");
```

Additional information available on [Logentries website](https://logentries.com) and [Logentries Android repository](https://github.com/LogentriesCommunity/le_android).


### Binding details
Build requirements: Android SDK 2.3+ (API 15+)

Runtime requirements: Android OS 2.3+ (API 15+)