var App = App || {};
App.MapProviders = App.MapProviders || {};

App.MapProviders.Leaflet = function(){
	this.map;
	
	createMap = function(elementId){
		this.map = new L.Map(elementId);
		this.addBaseMap();
		return map;
	};

	addBaseMap = function() {
		var baseMap = new L.TileLayer("http://{s}.tiles.mapbox.com/v3/mapbox.mapbox-light/{z}/{x}/{y}.png", {
            attribution: 'Map data by MapBox',
            maxZoom: 18
        });
        this.addLayer(baseMap);
	};

	addLayer = function(layer){
		this.map.addLayer(layer);

	};

	setView = function(options){
		this.map.setView(new L.LatLng(options.lat, options.lon), options.zoom)

	};

	return {
		createMap: createMap,
		addBaseMap: addBaseMap,
		addLayer: addLayer,
		setView: setView,
		map: this.map
	}
};

App.MapProviders.Leaflet.Layer = function(mapProvider){
	this.map;
	this.layer = new L.GeoJSON();

}(App.MapProviders.Leaflet);

