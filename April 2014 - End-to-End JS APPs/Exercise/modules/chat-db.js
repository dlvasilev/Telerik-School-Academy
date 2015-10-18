var mongoose = require('mongoose'),
	chat = require("../models/chat"),
	Chat = mongoose.model('Chat'),
	user = require("../models/user"),
	User = mongoose.model('User');

mongoose.connect('mongodb://localhost/ChatHomework');

exports.registerUser = function(obj){
	var usr = new User({ user: obj.user, pass: obj.pass });
	usr.save(function(err) {
		if(err) console.log("Error saving user: " + err);
		console.log('User saved!');
	});
};

exports.sendMessage = function(obj){
	var msg = new Chat({ from: obj.from, to: obj.to, text: obj.text });
	msg.save(function(err) {
		if(err) console.log("Error saving message: " + err);
		console.log('Message saved!');
	});
};

exports.getMessages = function(obj){
	Chat.find({ from: obj.with, to: obj.and }).exec(function(err, data){
		if(err) console.log("Error getting messages: " + err);
		console.log("All messages between them are:");
		if(data.length == 0){
			Chat.find({ from: obj.with, to: obj.and }).exec(function(err, data){
				console.log(data);
			});
		} else {
			console.log(data);
		}
	});
}
