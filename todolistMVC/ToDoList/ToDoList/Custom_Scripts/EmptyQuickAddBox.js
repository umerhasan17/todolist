﻿$(document).ready(function () {

    'keydown input[type="text"]'; function EmptyQuickAddBox (event, template) {
        if (27 === event.which || 13 === event.which) {
            event.preventDefault();
            //this should delete value from the input
            event.currentTarget.value = "";
        }
    }

});