app.directive('vacioDirective',function(){

	return {
		require: 'ngModel',
		link: function(scope, elm, attrs, ngModel) {

			ngModel.$validators.vacioDirective = function(modelValue) {

				if (ngModel.$isEmpty(modelValue)) {
					  return false;
				}

				else {
					return true;
				}
			};
		}
	};

});


