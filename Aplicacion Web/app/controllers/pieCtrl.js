var pieCtrl = app.controller('pieCtrl', function ($scope, $compile, $state) {

  $scope.modalContacto= function(){
    $("#contacto-modal").modal("show");
  }

});
