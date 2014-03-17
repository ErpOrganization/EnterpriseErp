$(document).ready(function () {

    /* Register Events */
    $(".navlink").on("click", addNewTab);



    /*functions*/
    function addNewTab(event) {
        /*Avoid Http Requests when clicked*/
        event.preventDefault();

        /*Add a new tab to right side*/
        $('#righttabs').tabs('add', {
            title: $(this).text(),
            content: 'Tab Body',
            closable: true,
            tools: [{
                iconCls: 'icon-mini-refresh',
                handler: function () {
                    alert('refresh');
                }
            }]
        });
    }


});