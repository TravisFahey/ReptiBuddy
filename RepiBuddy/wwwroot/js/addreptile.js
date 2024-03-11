$(document).ready(function () {
    $.ajax({
        url: RootUrl + 'Home/GetReptileTypes',
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            console.log(data);
            $('#typeDropdown').empty();
            $('#typeDropdown').append(new Option('Select an option...', ''));

            $.each(data, function (index, item) {
                $('#typeDropdown').append(new Option(item.type, item.id));
            });
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error('AJAX call failed:', textStatus, errorThrown);
        }
    });
});