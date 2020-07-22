$("#city").on("click", function () {
    var url = "api/weathers";
    $.getJSON(url, function (data) {

        console.log(data);
        //document.getElementById("city").value = data.brid;
    });
});