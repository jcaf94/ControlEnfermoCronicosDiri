var menuCtrl = app.controller('menuCtrl', function ($scope, $compile, $state) {

  var logo = setTimeout(function () {

    $('.logo-parte1').addClass('oculto');

    $('.logo-parte2').addClass('animacion-logo-parte2');

  }, 2000);

  var logo2 = setTimeout(function () {

    $('.logo-parte2').addClass('oculto');

    $('.menu-wrapper').removeClass('oculto');

  }, 3000);


  $('[has-ripple="true"]').click(function () {

    var timer1 = setTimeout(function () {

      $(this).toggleClass('clicked');
      $('.menu').toggleClass('open');

    }, 70);

    var timer2 = setTimeout(function () {

      $('body').removeAttr('class').addClass('bg-principal');
      $('#contenedor-logo').removeAttr('class').addClass('bg-cabecera-principal');

    }, 800);

  });


  $('.menu a').each(function (index) {
    var thismenuItem = $(this);

    thismenuItem.click(function (event) {
      event.preventDefault();

      $('.menuitem-wrapper').eq(index).addClass('spin');

      var timer = setTimeout(function () {

        $('body').removeAttr('class').addClass('bg-' + index);

        $('.menuitem-wrapper').eq(index).removeClass('spin');
        $('.menu').removeClass('open');
        $('.menu-btn').removeClass('clicked');
        $('.menu-btn').addClass('menu-cerrar');


        switch (index) {

          case 0:
            $state.go("chronicall.publico.login");
            break;
          case 1:
            $state.go("chronicall.publico.registro");
            break;
          case 2:
            $state.go("chronicall.publico.descarga");
            break;
          case 3:
            $state.go("chronicall.publico.servicios");
            break;
          case 4:
            $state.go("chronicall.publico.informacion");
            break;
          default:
            $state.go("chronicall.publico.inicio");
            break;
        }

        $('#contenedor-logo').removeAttr('class').addClass('bg-cabecera-' + index);

      }, 800);
    });
  });


});
