function initHome() {
    const $mainSlider = $("#main-slider");
    $mainSlider.owlCarousel({
        items: 3,
        pagination: false,
        navigation: false,
        autoPlay: true,
        stopOnHover: true
    });
    const $latestNews = $("#latest-news");
    $latestNews.owlCarousel({
        items: 4,
        pagination: true,
        autoPlay: true,
        stopOnHover: true,
    });
}