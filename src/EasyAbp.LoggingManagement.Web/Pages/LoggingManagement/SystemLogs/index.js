$(function () {

    var l = abp.localization.getResource('EasyAbpLoggingManagement');

    var service = easyAbp.loggingManagement.systemLogs.systemLog;
    var detailModal = new abp.ModalManager(abp.appPath + 'LoggingManagement/SystemLogs/DetailModal');

    var dataTable = $('#SystemLogTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList, function () {
            return { queryString: queryString, startTime: startTime, endTime: endTime }
        }),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Detail'),
                                action: function (data) {
                                    currentDetailModalData.level = data.record.level
                                    currentDetailModalData.logName = data.record.logName
                                    currentDetailModalData.logValue = data.record.logValue
                                    currentDetailModalData.time = data.record.time
                                    detailModal.open();
                                }
                            }
                        ]
                }
            },
            { data: "time" },
            { data: "level" },
            { data: "logName" },
        ]
    }));
    
    $('#search-button').click(function (e) {
        queryString = $('#QueryModel_QueryString').val()
        startTime = $('#QueryModel_StartTime').val()
        endTime = $('#QueryModel_EndTime').val()
        dataTable.ajax.reload()
    })
});