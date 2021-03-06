var express = require('express');
var app     = express()
var server  = require('http').createServer(app);
var people  = [
	{ Name: "John Doe" },
	{ Name: "Jane Doe" }
];

server.listen(process.env.PORT || 3000);

app.set('view engine', 'ejs');
app.set('view options', { layout: false });
app.use(express.methodOverride());
app.use(express.bodyParser());  
app.use(app.router);

app.get('/peeps', function (req, res) {
	res.writeHead(200, { 'Content-Type': 'application/json' });
	res.write(JSON.stringify(people));
	console.log("Returned: "+ JSON.stringify(people))
	res.end();
});

app.post('/peeps', function (req, res) {
	people.push(req.body);
	res.writeHead(200, { 'Content-Type': 'application/json' });
	res.write(JSON.stringify(req.body));
	console.log("Created: " + JSON.stringify(req.body))
	res.end();
});
