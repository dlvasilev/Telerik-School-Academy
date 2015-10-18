var fs = require( "fs" ),
    formidable = require( "formidable" ),
    mime = require( "mime" );

module.exports = function(req, res) {
    console.log( "Request for 'upload' is called." );
        
    var form = new formidable.IncomingForm();

    console.log( "Preparing upload" );


    form.parse( req, function( error, fields, files ){
        console.log( "Completed Parsing" );

        if( error ){
            res.writeHead( 500, { "Content-Type" : "text/plain" } );
            res.end( "CRAP! " + error + "\n" );
            return;
        }

        fs.renameSync( files.upload.path, "./uploads/" + files.upload.name );

        res.writeHead( 200, { "Content-Type" : "text/html" } );
        res.write("Recieved file!");
        res.end();       
    });
};