var path = require('path');
var express = require('express');
var logger = require('morgan');
var http = require('http');
var body = require("body-parser");

var app = express();

app.use(logger('dev'));

var path = require('path');
app.use(express.static(__dirname + '/public'));  

app.use(body.json());

app.use(function(req, res, next) {
  res.header("Access-Control-Allow-Origin", "*");
  res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
  next();
});

app.get("/api/data", function(req ,res){


});

app.listen(4500);
console.log('listening on port 4500');