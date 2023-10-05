window.addEventListener('scroll', function () {
    var header = document.getElementById('main-header');
    if (window.scrollY > 66) {
        header.classList.add('scrolled');
    } else {
        header.classList.remove('scrolled');
    }
});

let menuIcon = document.querySelector('#menu-icon');
let navbar = document.querySelector('.navbar');

menuIcon.onclick = () => {
    menuIcon.classList.toggle('bx-x');
    navbar.classList.toggle('active');
}

//let sections = document.querySelectorAll('section');
//let navLinks = document.querySelectorAll('header nav a');

//window.onclick = () => {

//}

document.addEventListener('DOMContentLoaded', function () {
    const navLinks = document.querySelectorAll('.navbar a');

    navLinks.forEach(function (link) {
        link.addEventListener('click', function (event) {
            // Remove 'active' class from all links
            navLinks.forEach(function (link) {
                link.classList.remove('active');
            });

            // Add 'active' class to the clicked link
            this.classList.add('active');
        });
    });
});

//$(document).ready(function () {
//    $(".description").each(function () {
//        var content = $(this).text();
//        var words = content.split(' ');
//        if (words.length > 50) { // Adjust the word limit as needed
//            var shortText = words.slice(0, 50).join(' ');
//            var longText = words.slice(50).join(' ');
//            $(this).html(shortText + '<span class="more-content" style="display:none;">' + longText + '</span>');
//        }
//    });

//    $(".read-more").click(function (e) {
//        e.preventDefault();
//        $(this).prev(".description").find(".more-content").toggle();
//    });
//});

//document.querySelector('.toggle-description').addEventListener('click', function (e) {
//    e.preventDefault(); // Prevent default link behavior

//    const shortDesc = document.querySelector('.short-description');
//    const fullDesc = document.querySelector('.full-description');

//    if (fullDesc.style.display === 'none' || fullDesc.style.display === '') {
//        shortDesc.style.display = 'none';
//        fullDesc.style.display = 'block';
//    } else {
//        shortDesc.style.display = 'block';
//        fullDesc.style.display = 'none';
//    }
//});
