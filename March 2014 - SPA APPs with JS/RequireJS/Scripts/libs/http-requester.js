define(["jquery", "rsvp"], function ($) {
	function getJSON(serviceUrl) {
		var promise = new RSVP.Promise(function(resolve, reject) {
			$.ajax({
				url: serviceUrl,
				type: "GET",
				dataType: "html",
				success: function (data) {
					resolve(data);
				},
				error: function(err) {
					reject(err);
				}
			});
		});
		return promise;
	}

	function postJSON(serviceUrl, data) {
		var promise = new RSVP.Promise(function (resolve, reject) {
			$.ajax({
				url: serviceUrl,
				dataType: "json",
				type: "POST",
				contentType: "application/json",
				data: JSON.stringify(data),
				success: function (data) {
					resolve(data);
				},
				error: function (err) {
					reject(err);
				}
			});
		});
		return promise;
	}

	return {
		getJSON: getJSON,
		postJSON: postJSON
	}
});