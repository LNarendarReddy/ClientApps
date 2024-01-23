    var $dialog;

    $(document).ready(function () {
        LoadEmployees();

        $('body').on("click", "a.popup", function (e) {
            e.preventDefault();
            var page = $(this).attr('href');
            OpenPopup(page);
        });
    });


    function LoadEmployees() {
        $('#update_panel').html('Loading Data...');

        $.ajax({
            url: '/Employee/EmployeeList',
            type: 'GET',
            dataType: 'json',
            success: function (d) {
                if (d.length > 0) {
                    var $data = $('<table></table>').addClass('table table-responsive table-striped');
                    var header = "<thead><tr><th style='background-color: Orange; color: blue'>UserName</th><th style='background-color: Yellow; color: blue'>FullName</th><th style='background-color: Yellow; color: blue'>CNumber</th><th style='background-color: Yellow; color: blue'>EMail</th><th style='background-color: Yellow; color: blue'>Role</th><th style='background-color: Yellow; color: blue'>Designation</th><th style='background-color: Yellow; color: blue'>Reporting Lead</th><th style='background-color: Yellow; color: blue'>Action</th></tr></thead>";
                    $data.append(header);

                    $.each(d, function (i, row) {
                        var $row = $('<tr/>');
                        $row.append($('<td/>').html(row.UserName));
                        $row.append($('<td/>').html(row.FullName));
                        $row.append($('<td/>').html(row.CNumber));
                        $row.append($('<td/>').html(row.EMail));
                        $row.append($('<td/>').html(row.RoleName));
                        $row.append($('<td/>').html(row.DesignationName));
                        $row.append($('<td/>').html(row.ReportingLead));
                        $row.append($('<td/>').html("<a href='/Employee/Update/" + row.UserInfoID + "' class='popup'>Edit</a> | <a href='/Employee/Delete/" + row.UserInfoID + "' class='popup'>Delete</a>"));
                        $data.append($row);
                    });

                    $('#update_panel').html($data);
                }
                else {
                    var $noData = $('<div/>').html('No Data Found!');
                    $('#update_panel').html($noData);
                }
            },
            error: function () {
                alert('Error! Please try again.');
            }
        });
    }

    //open popup  
    function OpenPopup(Page) {
        var $pageContent = $('<div/>');
        $pageContent.load(Page);
        $dialog = $('<div class="popupWindow" style="overflow:hidden"></div>')
            .html($pageContent)
            .dialog({
                draggable: true,
                autoOpen: false,
                resizable: true,
                model: true,
                //autoResize:true,
                height: 600,
                width: 800,
                close: function () {
                    $dialog.dialog('destroy').remove();
                }
            })
        $dialog.dialog('open');
    }