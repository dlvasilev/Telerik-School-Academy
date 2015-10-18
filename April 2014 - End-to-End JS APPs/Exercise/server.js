var http = require("http"),
    url = require("url"),
    uploader = require("./uploader");

var server = http.createServer(function(req, res) {
    switch (url.parse(req.url).pathname) {
        case '/':
            form(req, res);
            break;
        case '/upload':
            uploader(req, res);
            break;
        default:
            error(req, res);
            break;
    }
});
server.listen(3000);

function error(req, res) {
    res.sendHeader(404, {"Content-Type": "text/plain"});
    res.write("Something Bad happened!");
    res.end();
}

function form (req, res) {
    var body = "<html>\n"+
               "<head>\n"+
                "\t<meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />\n"+
                "\t<title>Exercsie 1</title>\n"+
                "</head>\n"+
                "<body>\n"+
                "\t<form action='/upload' method='post' enctype='multipart/form-data'>\n" +
                "\t\t<input type='file' name='upload' />\n" +
                "\t\t<input type='submit' value='Upload File' />\n" +
                "\t</form>\n"+
                "</body>\n"+
                "</html>\n";

    console.log( "Request for 'start' is called." );
                
    res.writeHead( 200, { "Content-Type" : "text/html" } );
    res.end(body);
};