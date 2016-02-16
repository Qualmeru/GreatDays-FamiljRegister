



var LandingPageController = function ($scope) {

    /*$.ajax({
        url: "/Api/GetFamilys.ashx",
        type: "GET",
        success: function (data) {

            if (data) {
                model = data;
                $scope.models = {
                    modeldata: model,
                };
                return model;
            }

        }
    });*/
    //return model;
    //console.log(GetData());
    //$scope.data = GetData.test
    GetData().then(function (data) {
        console.log(data);
    })
    //GetData();
};




/* The $inject property of every controller 
(and pretty much every other type of object in Angular) 
needs to be a string array equal to the controllers arguments,
only as strings
*/

LandingPageController.$inject = ['$scope'];

