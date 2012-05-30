(function () {

    var scripts = [
        'lvector.js',

        'core/Util.js',
        'core/Class.js',

        'layer/Layer.js',
        'layer/GeoJSONLayer.js',
        'layer/EsriJSONLayer.js',

        'layer/AGS.js',
        'layer/A2E.js',
        'layer/GeoIQ.js',
        'layer/CartoDB.js',
        'layer/PRWSF.js',
        'layer/GISCloud.js'
    ];

    function getSrcUrl() {
        var scripts = document.getElementsByTagName('script');
        for (var i = 0; i < scripts.length; i++) {
            var src = scripts[i].src;
            if (src) {
                var res = src.match(/^(.*)lvector-include\.js$/);
                if (res) {
                    return res[1];
                }
            }
        }
    }

    var path = getSrcUrl();
    for (var i = 0; i < scripts.length; i++) {
        document.writeln("<script type='text/javascript' src='" + path + scripts[i] + "'></script>");
    }
})();