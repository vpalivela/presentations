## iOS Development With C-Sharp
This folder contains iOS Solutions implemented using Xamarin.iOS at NDDNUG on October 2, 2013. The slides for the talk are located on [my site](http://venkatpalivela.com/talks/talk/ios-development-csharp-nddnug)

***
### Overview
There are 4 Projects implemented.

* **Hello World** - Learn how the button click events work in iOS
* **Hello Views** - Learn how navigation between different view controllers work in iOS.
* **Hello Rest**  - Learn how to communicate with a Rest Service in iOS
* **Rest Server** - The server used for Hello Rest demo.

***
### Implementing the REST API

If you want to test the API before using it in a client application, run the server locally and then you can invoke the REST services straight from a browser address bar. 

#### Run Locally

Go to http://nodejs.org and install NodeJS

###### Install all the dependencies:

    npm install (you may need to prefix this with sudo if you're on Mac)

###### Run the app:

    npm start

###### Then navigate to [http://localhost:3000/people](http://localhost:3000/people)

#### Avaliable Resources

The full REST API for people server consists of the following methods:

METHOD        | URL           | ACTION  
------------- | ------------- | ------
GET           | /people       | Retrieve all people 
POST          | /people       | Add a new person

#### Testing the API using cURL

Using cURL, you can test the API with the following commands:

###### Get all people:
		
	$ curl -i -X GET http://localhost:3000/people

###### Add a new person:
		
	$ curl -i -H "Content-Type: application/json" -H "Accept: application/json" -X POST -d '{"Name":"bob"}' http://localhost:3000/people

