var App = App || {};

App.MapView = Backbone.View.extend({
	el: "div#map",

	initialize: function() {
		this.mapProvider = this.options.mapProvider;
		this.initialCenter = this.options.initialCenter || { lat: 39.937, lon: -105.0691};
		this.render();
	},

	setInitialView: function() {
		this.mapProvider.setView({
			lat: this.initialCenter.lat,
			lon: this.initialCenter.lon,
			zoom: 12
		})
	},

	render: function() {
		this.mapProvider.createMap(this.el.id)
		this.setInitialView();
	}
});