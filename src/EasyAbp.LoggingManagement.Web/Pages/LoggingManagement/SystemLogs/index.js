$(function () {

    var l = abp.localization.getResource('EasyAbpLoggingManagement');

    var service = easyAbp.loggingManagement.systemLogs.systemLog;
    var detailModal = new abp.ModalManager(abp.appPath + 'LoggingManagement/SystemLogs/DetailModal');

    var dataTable = $('#PaymentTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Detail'),
                                action: function (data) {
                                    detailModal.open({ logName: data.record.logName, logValue: data.record.logValue, time: data.record.time });
                                }
                            }
                        ]
                }
            },
            { data: "logName" },
            { data: "logValue" },
            { data: "time" },
        ]
    }));
});