export function AssignDoubleClickEvent() {
    $("#match_table").on('dblclick',
        function (e, arg1, arg2) { console.log("asdf"); })
}