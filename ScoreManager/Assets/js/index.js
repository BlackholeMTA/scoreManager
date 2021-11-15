
$(document).ready(function (){
    // $("#home-slide").carousel({ 
    //         interval: 30, // thiet lap thoi gian
    //         ride: "carousel"  // cho no tu dong chay ngay khi vao
    //     });
    // $("#customer-slide").carousel({ 
    //         interval: 30, // thiet lap thoi gian
    //         ride: "carousel"  // cho no tu dong chay ngay khi vao
    //     });
	$(window).scroll(function () {
        if ($(this).scrollTop() != 0) {
            $('#btn-top').stop().fadeIn(150);
        } else {
            $('#btn-top').stop().fadeOut(150);
        }
    });
    $('#btn-top').click(function () {
        $('body,html').stop().animate({scrollTop: 0}, 800);
    });

        
    
});
