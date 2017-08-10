$(window).load(function () {
    $("html, body").animate({ scrollTop: $(document).height() }, "slow");
    return false;
});

$('#toTop').click(function () {
    $("html, body").animate({ scrollTop: 0 }, "slow");
    return false;
});