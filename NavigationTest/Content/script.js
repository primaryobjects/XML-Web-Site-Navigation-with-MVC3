var timeout = 500;
var closetimer = 0;
var ddmenuitem = 0;

function topNavigation_open() {
    topNavigation_canceltimer();
    topNavigation_close();
    ddmenuitem = $(this).find('ul').css('visibility', 'visible');
}

function topNavigation_close()
{ if (ddmenuitem) ddmenuitem.css('visibility', 'hidden'); }

function topNavigation_timer()
{ closetimer = window.setTimeout(topNavigation_close, timeout); }

function topNavigation_canceltimer() {
    if (closetimer) {
        window.clearTimeout(closetimer);
        closetimer = null;
    } 
}

$(document).ready(function () {
    $('#top-navigation > li').bind('mouseover', topNavigation_open)
    $('#top-navigation > li').bind('mouseout', topNavigation_timer)
});

document.onclick = topNavigation_close;