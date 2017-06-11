var seccionCtrl = app.controller('seccionCtrl', function ($scope, $compile, $state) {

  $('.volver-menu').click(function () {

    var timer = setTimeout(function () {

      $('body').removeAttr('class').addClass('bg-principal');

    }, 100);

  });



  $scope.cabeceraInicio = function () {

    $('#contenedor-logo').removeAttr('class').addClass('bg-cabecera-principal');

  };


});
