var mongoose = require('mongoose');
var chatSchema = new mongoose.Schema({
	from: String,
	to: String,
	text: String
});

mongoose.model('Chat', chatSchema);