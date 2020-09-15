var $f;
var $m;
var vegFlag = false;
$(document).ready(function () {
    $("#goVegBtn").on("click", function () {
        if (!vegFlag) {
            $f = $('.fish').parent().parent().detach();
            $("li.hamburger").replaceWith("<li class='portobello'><em>portobello mushrooms</em></li>");
            $(".meat").after("<li class='tofu'><em>tofu</em></li>");
            $m = $(".meat").detach();
            vegFlag = true;
        }
    });

    $("#restoreBtn").on("click", function () {
        if (vegFlag) {
            $(".leftColumn ul").children().first().before($f);
            $("li.portobello").replaceWith("<li class='hamburger'>hamburger</li>");
            $(".tofu").each(function (i) {
                $(this).after($m[i]);
                $(this).remove();
            });
            vegFlag = false;
        }
    });
});