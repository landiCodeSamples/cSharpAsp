
$(window).load(function () {
    $("#displayResults").addClass('dynamicFpClass').hide();
});
$('#btnGetUserInfo').click(function (event) {
    $("#userData").hide();
    $("#displayResults").show();
});
