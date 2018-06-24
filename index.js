$(function () {
    cleanRoom().then(function (){
        return removeGarbage();
    }).then(function () {
        return wonIceCreame();
    }).then(function() {
        alert("Won")
    }).catch(function (){
        alert("Lost")
    })    
});

let cleanRoom = function () {
    return new Promise(
    function(resolve, reject)
    {
        resolve('Room cleaned');
    });
};

let removeGarbage = function (){
    return new Promise(function(resolve, reject){
        resolve("Garbaged removed");
    });
};

let wonIceCreame = function (){
    return new Promise(function (resolve, reject){
        resolve("Won Chocolate Ice Cream");
         //reject("False Offer !");
    });
};