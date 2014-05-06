function initialize() {
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
        'address': '17 Ettrick Street, Dunedin, New Zealand'
    },
        function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                var mapOptions = {
                    center: results[0].geometry.location,
                    zoom: 16,
                    mapTypeId: google.maps.MapTypeId.ROADMAP
                };
                var map = new google.maps.Map(document.getElementById("map_canvas"),
                  mapOptions);
                // create a marker
                var marker = new google.maps.Marker({
                    position: results[0].geometry.location,
                    map: map,
                    title: 'My Place'
                });
            }
        });
}