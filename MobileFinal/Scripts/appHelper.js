$(function () {

    //$("#hess").click(function () {
    //    alert("me");
    //});

    

});

function removeItem(itemtoremove, itemarray, displayitemarray) {
        //get position in array           
        var pos = itemarray.indexOf(itemtoremove);
        itemarray.splice(pos, 1);
        displayitemarray.splice(pos, 1);
    }