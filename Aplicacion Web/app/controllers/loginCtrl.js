var loginCtrl = app.controller('loginCtrl', function ($scope, $compile, $state, $http) {

    $scope.loguear = function () {


        $state.go("chronicall.privado.inicio");
        $('body').removeAttr('class').addClass('bg-secundario');



        /*
                $http({

                    method: 'GET',
                    url: 'http://127.0.0.1:8080/api/Location/ReadAll'

                }).then(function (response) {


                    alert("exito" + response);

                }, function (response) {

                    alert("error" + JSON.stringify(response));

                });
        */




    };

});
