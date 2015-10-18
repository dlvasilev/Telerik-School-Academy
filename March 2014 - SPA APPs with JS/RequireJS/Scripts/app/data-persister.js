define(["httpRequester"], function (httpRequester) {
	function getStudents() {	
		var data = httpRequester.getJSON("Scripts/data/students.json");
		return JSON.parse(data);
	}

	return {
		students: getStudents
	}
});