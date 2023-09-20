window.addEventListener('scroll', function () {
    var header = document.getElementById('main-header');
    if (window.scrollY > 66) {
        header.classList.add('scrolled');
    } else {
        header.classList.remove('scrolled');
    }
});

/*window.onload = function () {*/
//    window.addEventListener('scroll', function () {
//        if (window.pageYOffset > 66) {
//            document.querySelector("main-header").classList.add('scrolled')
//        }
//    });
///*}*/