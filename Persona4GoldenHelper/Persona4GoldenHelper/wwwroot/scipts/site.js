﻿// Determine if the 'return to top' button should show
$(window).on('scroll', function () {
    // don't allow the return to top display on mobile (get's in the way)
    if ($(window).width() < 768) {
        $('#return-to-top').hide();
        return;
    }

    if (document.body.scrollTop > 1000 || document.documentElement.scrollTop > 1000) {
        $('#return-to-top').fadeIn(700);
    }
    else {
        $('#return-to-top').fadeOut(700);
    }
});

$('#return-to-top').on('click', function () {
    $('html, body').animate({
        scrollTop: 0
    }, 1000);
});

// When the user enters something in a search bar, try filtering all the tables in the view
$('input').on('keyup', function () {
    let value = $(this).val().toLowerCase();
    let filterContent = [];

    // check if the table has multiple tbodies, this means the tbodies should be hidden, not the tr (as when multiple tbodies are present it means there are merged cells)
    let tables = $('table');
    for (let table of tables) {
        $(table).show(); // this is required as if the table is hidden, setting the children to unhidden will not work
        $(table).siblings('.sub-header').show();

        if (table.tBodies.length > 1) {
            filterContent = table.tBodies;
        }
        else {
            filterContent = table.tBodies[0].children;
        }

        $(filterContent).filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
        });

        // hide table if all content is hidden
        let numberOfVisibleRecords = $(filterContent).filter(':visible').length;
        if (numberOfVisibleRecords === 0) {
            $(table).hide();
            $(table).siblings('.sub-header').hide();
        }
    }

    // show no results if all tables are hidden
    let numberOfVisibleTables = $('table').filter(':visible').length;
    console.log(numberOfVisibleTables);
    if (numberOfVisibleTables === 0) {
        $('.no-results').show();
    }
    else {
        $('.no-results').hide();
    }
});