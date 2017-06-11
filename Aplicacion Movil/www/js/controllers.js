angular.module('starter.controllers', [])

  .controller('AppCtrl', function ($scope, $ionicModal, $timeout, $compile, $state, $http, $ionicLoading) {

    // With the new view caching in Ionic, Controllers are only called
    // when they are recreated or on app start, instead of every page change.
    // To listen for when this page is active (for example, to refresh data),
    // listen for the $ionicView.enter event:
    //$scope.$on('$ionicView.enter', function(e) {
    //});


    // Form data for the login modal
    $scope.loginData = {};

    // Create the login modal that we will use later
    $ionicModal.fromTemplateUrl('templates/login.html', {
      scope: $scope
    }).then(function (modal) {
      $scope.modalLogin = modal;
    });

    // Triggered in the login modal to close it
    $scope.closeLogin = function () {
      $scope.modalLogin.hide();
    };

    // Open the login modal
    $scope.login = function () {
      $scope.modalLogin.show();
    };

    // Perform the login action when the user submits the login form
    $scope.doLogin = function () {
      console.log('Doing login', $scope.loginData);

      // Simulate a login delay. Remove this and replace with your login
      // code if using a login system

      $state.go('app.principal');
      //location.href='#/app/principal';

      $timeout(function () {
        $scope.closeLogin();
      }, 500);


    };

    $scope.$on('$destroy', function () {
      $scope.modalLogin.remove();
    });

    // ----------------------------------------------------------------------


    // Form data for the register modal
    $scope.registroData = {};

    // Create the register modal that we will use later
    $ionicModal.fromTemplateUrl('templates/registro.html', {
      scope: $scope
    }).then(function (modal) {
      $scope.modalRegistro = modal;
    });

    // Triggered in the register modal to close it
    $scope.closeRegistro = function () {
      $scope.modalRegistro.hide();
    };

    // Open the register modal
    $scope.registro = function () {
      $scope.modalRegistro.show();
    };

    // Perform the register action when the user submits the register form
    $scope.doRegistro = function () {
      console.log('Doing register', $scope.loginData);

      // Simulate a register delay. Remove this and replace with your register
      // code if using a register system
      $timeout(function () {
        $scope.closeRegistro();
      }, 1000);
    };

    $scope.$on('$destroy', function () {
      $scope.modalRegistro.remove();
    });



    $scope.toggle1_registro = false;
    $scope.toggle2_registro = false;
    $scope.toggle3_registro = false;
    $scope.toggle4_registro = false;



    // ----------------------------------------------------------------------

    $scope.openCentros = function () {
      $state.go('app.centros');
    };

    // ----------------------------------------------------------------------

    $scope.openMedicos = function () {
      $state.go('app.medicos');
    };

    // ----------------------------------------------------------------------

    $scope.openFamiliares = function () {
      $state.go('app.familiares');
    };

    // ----------------------------------------------------------------------

    $scope.openDiario = function () {
      $state.go('app.diario');
    };

    // ----------------------------------------------------------------------

    $scope.openCitas = function () {
      $state.go('app.citas');
    };

    // ----------------------------------------------------------------------

    $scope.openHistorial = function () {
      $state.go('app.historial');
    };

    // ----------------------------------------------------------------------

    $scope.openConfiguracion = function () {
      //$state.go('app.configuracion');
    };

    // ----------------------------------------------------------------------

    $scope.openAyuda = function () {
      //$state.go('app.ayuda');
    };

    // ----------------------------------------------------------------------



  })

  .controller('PlaylistsCtrl', function ($scope, $compile, $state, $http, $ionicLoading) {
    $scope.playlists = [
      {
        title: 'Reggae',
        id: 1
      },
      {
        title: 'Chill',
        id: 2
      },
      {
        title: 'Dubstep',
        id: 3
      },
      {
        title: 'Indie',
        id: 4
      },
      {
        title: 'Rap',
        id: 5
      },
      {
        title: 'Cowbell',
        id: 6
      }
  ];
  })

  .controller('PlaylistCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {})


  .controller('InicioCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {

    $scope.options = {
      autoplay: 2500,
      loop: false,
      speed: 1000,
      slidesPerView: 1,
      centeredSlides: true
    }

  })


  .controller('PrincipalCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })

  .controller('CentrosCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })

  .controller('MedicosCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })

  .controller('FamiliaresCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })

  .controller('DiarioCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })

  .controller('CitasCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })

  .controller('HistorialCtrl', function ($scope, $stateParams, $compile, $state, $http, $ionicLoading) {


  })
