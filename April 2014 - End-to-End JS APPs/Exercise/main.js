var http = require("http");

var chatDB = require("./modules/chat-db");

var server = http.createServer(function(req, res){
    
}).listen(3000);

console.log("Server running on port 3000");


console.log("Saving users seed...");

console.log("Saving user { user: 'DonchoMinkov', pass: '123456q' }");
chatDB.registerUser({ user: 'DonchoMinkov', pass: '123456q' });

console.log("Saving user { user: 'NikolayKostov', pass: '123456q' }");
chatDB.registerUser({ user: 'NikolayKostov', pass: '123456q' });


console.log("Saving messages seed...");

console.log("Saving message { from: 'DonchoMinkov', to: 'NikolayKostov', text: 'Hey Niki!' }");
chatDB.sendMessage({ from: 'DonchoMinkov', to: 'NikolayKostov', text: 'Hey Niki!' });

console.log("Saving message { user: 'NikolayKostov', to: 'DonchoMinkov', text: 'Hey Doncho' }");
chatDB.sendMessage({ from: 'DonchoMinkov', to: 'NikolayKostov', text: 'Hey Niki!' });

console.log("Getting messages...");

console.log("Getting messages between { with: 'DonchoMinkov', and: 'NikolayKostov' }");
chatDB.getMessages({ with: 'DonchoMinkov', and: 'NikolayKostov' });


