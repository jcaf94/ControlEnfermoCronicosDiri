
var loginCtrl = app.controller('loginCtrl', function ($scope, $compile, $state, $http) {

    $scope.loguear = function () {

        //var Indata = {body:'Hola buenas tardes'};


        $http({

            method: 'POST',
            url: 'http://gplsi.dlsi.ua.es:80/services/pln/rest/v1/lang/detect',
            headers: {
                'Content-Type': undefined
            },
           // data: Indata
            /*data: $.param({body:'hola me aburro'})*/

            data: {
                 'body': 'hola buenas tardes'
            }

        }).then(function (response) {

            //Success

            alert("exito" + response);
            alert(JSON.stringify(response));

        }, function (response) {

            //Error
            alert("error" + response);
            alert(JSON.stringify(response));
        });


    };

});



/*

var loginCtrl = app.controller('loginCtrl', function ($scope, $compile, $state, $http) {

    $scope.login = function () {

        $http({

            method: 'GET',
            url: 'app/php/autenticacion/login.php'

        }).then(function (response) {


            alert("exito");

        }, function (response) {

            alert("error");

        });

    };

});

*/
