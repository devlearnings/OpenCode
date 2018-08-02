function FillState() {
    var countryId = $('#CountryId').val();
    $.ajax({
        url: '/Employees/FillState',
        type: "GET",
        dataType: "JSON",
        data: { Country: countryId },
        success: function (states) {
            $("#StateId").html(""); // clear before appending new list
            $.each(states, function (i, state) {
                $("#StateId").append(
                    $('<option></option>').val(state.StateId).html(state.StateName));
            });
        }
    });
};