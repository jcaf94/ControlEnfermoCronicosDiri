app.directive('usuarioDirective',function(){

	return {
		require: 'ngModel',
		link: function(scope, elm, attrs, ngModel) {

			ngModel.$validators.usuarioDirective = function(viewValue) {

				if (/^[a-zA-Z0-9]*$/.test(viewValue)) {
					  return true;
				}

				else {
					return false;
				}
			};
		}
	};

});

