app.directive('passwordDirective',function(){

  return {

      require: 'ngModel',
      link: function (scope, elem, attrs, ngModel) {

        var firstPassword = '#' + attrs.passwordDirective;

        elem.add(firstPassword).on('keyup', function () {

          scope.$apply(function () {

            var v = elem.val()===$(firstPassword).val();
            ngModel.$setValidity('pwmatch', v);

          });

        });

      }

    }

});

