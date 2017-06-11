var panelesCtrl = app.controller('panelesCtrl', function ($scope, $compile, $state) {

  $scope.modalCentros= function(){
    $("#centros-modal").modal("show");
  }

  $scope.modalMedicos= function(){
    $("#medicos-modal").modal("show");
  }

  $scope.modalFamiliares= function(){
    $("#familiares-modal").modal("show");
  }

  $scope.modalDiario= function(){
    $("#diario-modal").modal("show");
  }

  $scope.modalCitas= function(){
    $("#citas-modal").modal("show");
  }

  $scope.modalHistorial= function(){
    $("#historial-modal").modal("show");
  }

});
