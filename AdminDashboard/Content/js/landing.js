/*! light-blue - v3.3.0 - 2016-03-08 */
$(function () {
    $(".back-to-top").on("click", function () {
        return $("html, body").animate({
            scrollTop: 0
        }, "fast"), !1
    })
});