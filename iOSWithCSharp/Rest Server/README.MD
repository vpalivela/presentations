### Implementing the REST API
If you want to test your API before using it in a client application, run the server locally and then you can invoke your REST services straight from a browser address bar. 

#### Run Locally

###### Install all the dependencies:

    npm install (you may need to prefix this with sudo if you're on Mac)

###### Run the app:

    npm start

###### Then navigate to [http://localhost:3000/people](http://localhost:3000/people)

#### Avaliable Resources

The full REST API for people server consists of the following methods:

METHOD        | URL           | ACTION  
------------- | ------------- | ------
`GET`         | `/people`     | Retrieve all people 
`POST`        | `/people`     | Add a new person

#### Testing the API using cURL

Using cURL, you can test the API with the following commands:

###### Get all people:
		
	$ curl -i -X GET http://localhost:3000/people

###### Add a new person:
		
	$ curl -i -H "Content-Type: application/json" -H "Accept: application/json" -X POST -d '{"Name":"bob"}' http://localhost:3000/people
