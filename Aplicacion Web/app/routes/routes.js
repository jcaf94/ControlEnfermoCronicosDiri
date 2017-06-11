app.config(function ($stateProvider, $urlRouterProvider) {

	$stateProvider

	.state({
		name:	"chronicall",
		cache: false,
		abstract: true,
		url:	"/chronicall",
		templateUrl:	"app/views/chronicall.html"
	})

	.state({
		name:	"chronicall.publico",
		cache: false,
		url:	"/publico",
		templateUrl:	"app/views/publico/index.html"
	})

		.state({
			name:	"chronicall.publico.inicio",
			cache: false,
			url:	"/inicio",
			templateUrl:	"app/views/publico/menu.html"
		})

		.state({
			name:	"chronicall.publico.login",
			cache: false,
			url:	"/login",
			templateUrl:	"app/views/publico/secciones/login.html"
		})

		.state({
			name:	"chronicall.publico.registro",
			cache: false,
			url:	"/registro",
			templateUrl:	"app/views/publico/secciones/registro.html"
		})

		.state({
			name:	"chronicall.publico.servicios",
			cache: false,
			url:	"/servicios",
			templateUrl:	"app/views/publico/secciones/servicios.html"
		})

		.state({
			name:	"chronicall.publico.informacion",
			cache: false,
			url:	"/informacion",
			templateUrl:	"app/views/publico/secciones/informacion.html"
		})

		.state({
			name:	"chronicall.publico.descarga",
			cache: false,
			url:	"/descarga",
			templateUrl:	"app/views/publico/secciones/descarga.html"
		})

	.state({
		name:	"chronicall.privado",
		cache: false,
		url:	"/privado",
		templateUrl:	"app/views/privado/index.html"
	})

		.state({
			name:	"chronicall.privado.inicio",
			cache: false,
			url:	"/inicio",
			templateUrl:	"app/views/privado/paneles.html"
		});


		$urlRouterProvider.otherwise("/chronicall/publico/inicio");

});
