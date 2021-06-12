// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var btnAbrirPopup= document.getElementById('btn btn-carrito'), 

overlay= document.getElementById('overlay'),

popup= document.getElementById('popup'),

btnCerrarPopup= document.getElementById('btn-cerrar-popup');

btnAbrirPopup.addEventListener('click', function(){
    overlay.classList.add('active');
    popup.classList.add('active');
});

btnCerrarPopup.addEventListener('click', function(){
    overlay.classList.remove('active');
    popup.classList.remove('active');
});