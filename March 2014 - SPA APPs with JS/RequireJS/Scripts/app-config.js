require.config({
	paths: {
		jquery: "libs/jquery-2.0.3",
		rsvp: "libs/rsvp.min",
		httpRequester: "libs/http-requester",
		mustache: "libs/mustache"
	}
});

require(["jquery", "mustache", "app/data-persister", "app/controls"], function ($, mustache, data, controls) {

	data.students().then(function(students){
        var studentTemplate = mustache.compile($("#student-template").innerHTML);
        var listView = controls.getListView(students.data);
        var listViewHtml = listView.render(studentTemplate);
        $("#content").innerHTML = listViewHtml;

        $("#selected-item").innerHTML = studentTemplate(students.data[0]);
    }, function(err) {
        console.log(err);
    })


    $(function () {
        $("#wrapper").on("click", "#toggle", function () {
            $("#content").toggle();
            if ($("#content").css('display') == 'none') {
                $("#toggle").html("Show");
            } else {
                $("#toggle").html("Hide");
            }
        });

        $("#wrapper").on("click", "#drop-down > li", function () {
            $("#content").toggle();
            if ($("#content").css('display') == 'none') {
                $("#toggle").html("Show");
            } else {
                $("#toggle").html("Hide");
            }
            $("#selected-item").html($(this).html());
        });
    });
});