var GetData = function ($http, $q) {

    console.log($q);
    var result = $q.defer();
    console.log($q.defer())
    //var model = [];
    /* $.get("/Api/GetFamilys.ashx", function (data) {
         // alert("Data Loaded: " + data);
         // console.log()
         model = data;
        return {
             data: data
         };
         });*/
    $http({
        method: 'GET',
        url: '/Api/GetFamilys.ashx',

    })
    .success(function (data) {
        result.resolve(data);
    })
    .error(function (data) {
        result.reject(data);
    });

    /* return {
         test: "asdsad"
     };
     console.log("sadasd");
     */
    return result.promise;

};


var App = angular.module('App', []);

App.factory('GetData',['$http', '$q ',GetData]);
App.controller('LandingPageController', LandingPageController);


//console.log(GetData());