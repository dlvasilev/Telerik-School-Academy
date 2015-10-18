(function ($) {
    $.fn.messageBox = function () {
        var $this = $(this);

        var newMsg = $('<div />'); //creating a div element to hold the message

        $($this).hide().append(newMsg); //appending it to a div from the body

        return $this; //return it, so I can chain the type of message
    }
}(jQuery));

//succes message
(function ($) {
    $.fn.success = function (message) {
        var $this = $(this);

        $this
            .text(message)
            .css('background-color', 'green')
            .css('color', 'white');

        $($this).fadeIn(3000);

        $($this).fadeOut(3000);

        return $this;
    }
}(jQuery));

//error message
(function ($) {
    $.fn.error = function (message) {
        var $this = $(this);

        $this
            .text(message)
            .css('background-color', 'red')
            .css('color', 'white');

        $($this).fadeIn(3000);

        $($this).fadeOut(3000);

        return $this;
    }
}(jQuery));

//loading the messages
window.onload = function () {
    var msgBox = $('#message-box').messageBox();    
    msgBox.error('You suck!')
    //timer to wait for the first call to finish its work.
    setTimeout(function () {
        msgBox.success('Just kidding. You are cool!');
    },6000)
};
