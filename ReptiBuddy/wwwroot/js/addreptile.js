$(document).ready(function () {
    getTypes();
    getSpecies();

    function getTypes() {
        $.ajax({
            url: RootUrl + 'Home/GetReptileTypes',
            method: 'GET',
            dataType: 'json',
            success: function (data) {
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
    }

    function getSpecies() {
        var typeId = $('#typeDropdown').val();

        if (typeId == null || typeId == "") {
            $('#speciesDropdown').attr("disabled", true);
        } else {
            $('#speciesDropdown').removeAttr("disabled");

            $.ajax({
            url: RootUrl + 'Home/GetReptileSpecies',
            method: 'GET',
            data: { "typeId": typeId },
            dataType: 'json',
            success: function (data) {
                console.log(data);
                $('#speciesDropdown').empty();
                $('#speciesDropdown').append(new Option('Select an option...', ''));

                $.each(data, function (index, item) {
                    $('#speciesDropdown').append(new Option(item.species, item.id));
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.error('AJAX call failed:', textStatus, errorThrown);
            }
        });
        }
        
    };
    

    $('#typeDropdown').on("change", function() {
        getSpecies();
    });
});