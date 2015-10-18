(function ($) {
    $.fn.dropdown = function () {

        var $this = $(this);
        $this.css('display', 'none');

        $this 
           .parent()
           .append('<div class="dropdown-list-container" />'); //could use .addClass().. but no point really

        $('.dropdown-list-container')
            .append('<ul class="dropdown-list-options" />');

        var $lenght = $('option').size(); //getting the number of options 

        for (var i = 1; i <= $lenght; i++) {
            $('.dropdown-list-options')
                //adding a new list item for each option
                .append('<li data-value="' + i + '"> ' + $('#dropdown option:nth-child(' + i + ')').text() + ' </li>');
        }

    }
}(jQuery));

window.onload = function () {

    $('#dropdown').dropdown();

}
