var mongoose = require('mongoose');
var userSchema = new mongoose.Schema({
	user: String,
	pass: String
});

mongoose.model('User', userSchema);