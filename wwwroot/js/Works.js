$(document).ready(function () {
    ///畫出作品清單
    WORK00WorksList();


});


function WORK00WorksList() {
    $("#WORKGrid").jqGrid('GridUnload');
    $("#WORKGrid").jqGrid({
        url: '/Home/WorksListGrid',
        datatype: "json",
        mtype: "POST",
        colModel: [
            { label: "", name: "ID", index: "ID", hidden: true },
            { label: "", name: "WORK_NAME", index: "WORK_NAME", hidden: true },
            { label: "Name", name: "", index: "", width: "200px", align: "center", formatter: WORK00WorkLink, sortable: false },
            { label: "Description", name: "DESCRIPTION", index: "DESCRIPTION", width: "800px", align: "center", sortable: false },
            { label: "Finished Date", name: "FINISH_DATE", index: "FINISH_DATE", width: "200px", align: "center", sortable: false },
        ],
        jsonReader: {                      //jqgrid讀取json的時候，需要配置jsonReader才能讀取。
            repeatitems: false,              //預設是true，但是我回傳的json的內容並不會按照順序回傳，故這邊要設定false，讓jsonReader是用搜尋name去塞入對應的值
        },
        height: 400,
        width: 1200,
        rowNum: 10,
        rownumWidth: 40,
        rowList: [10, 20, 30],
        viewrecords: true,
        rownumbers: true,
        pager: "#WORKPager",
        loadonce: true,
        loadComplete: function (data) {
            //$("#WORKList").show();
            //$("#WORKPager").show();
            //var rowCount = $('#WORKGrid').getGridParam("records");
            //if (rowCount == 0) {
            //    $("#WORKList").hide();
            //    alert('Oops! We cannot find any data.');
            //}
            //if (rowCount <= 10) {
            //    $("#WORKPager").hide();
            //}
        },
    });
    $("#WORKGrid").jqGrid("navGrid", "#WORKPager", { add: false, edit: false, del: false, search: false, refresh: false });
    $("#WORKGrid").trigger("reloadGrid", [{ current: true, page: 1 }]);
}

function WORK00WorkLink(cellvalue, options, rData) {
    return $.validator.format("<a href='/{0}/Index' style=\"color: blueviolet;\">{0}</a>", rData.WORK_NAME);

}