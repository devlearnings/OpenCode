jQuery.support.cors = true;
$(function () {
    $("form").submit(function (event) {
        var json = GetJSON();
        SaveData(json)
        .then(function (data) {
            alert("Success")
        })
        .catch(function (data) {
                alert("failed" + JSON.stringify(data));
        });
    });
});

let GetJSON = function () {
    let params = new Object();
    params["Name"] = $('#txtName').val();
    params["Email"] = $('#txtEmail').val();
    params["Phone"] = $('#txtPhone').val();

    let data = JSON.stringify(params);
    return data;
}

let SaveData = function (jsonDto) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: "http://localhost:54147/api/values",
            type: "POST",
            data: jsonDto,
            contentType: "application/json; charset=utf-8",
            dataType: "jsonp"
        })
            .done(
                function (res) { resolve(res); }
            )
            .fail(
                function (err) { JSON.stringify(err) ; reject(err); }
            )
    }
    )
};

// let SaveData = function (jsonDto) {
//     var  url =  "http://localhost:54147/api/values";

//         $.ajax({
           
//             crossDomain: true,  
//             async: false, 
//             type: "POST",
//             url: "http://localhost:54147/api/values",
//             data: jsonDto,
//             dataType: "json",
//             contentType: "application/json; charset=utf-8",
//             context: document.body
//         })
//             .done(
//                 function (res) { resolve(res); }
//             )
//             .fail(
//                 function (err) { JSON.stringify(err) ; reject(err); }
//          )


            
   
// };