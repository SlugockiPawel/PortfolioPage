// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*-------------------------------------------------------------------------------
  PRE LOADER
-------------------------------------------------------------------------------*/

//$(window).on('load', function () {
//    $('.preloader').fadeOut(1000); // set duration in brackets    
//});


/*-------------------------------------------------------------------------------
  Modals
-------------------------------------------------------------------------------*/

//email modal (sweetalert2)
function showEmailModal() {
    customSwal.fire({
        title: 'Success!',
        text: 'Thank You for your message. I will reply as soon as possible.',
        confirmButtonText: 'OK'
    });
}

const customSwal = Swal.mixin({
    customClass: {
        confirmButton: 'btn btn-primary text-light'
    },
    icon: 'success',
    iconColor:'#2c6b78',
    buttonsStyling: false
});


//modal carousel

$(document).ready(function() {
    $(".owl-carousel").owlCarousel({
        margin: 10,
        loop: true,
//        autoHeight: true,
        autoplay: true,
        autoplayHoverPause: true,
        autoplayTimeout: 4000,
        items: 1
    });
});