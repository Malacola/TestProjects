var App = new (Backbone.Router.extend({
	routes: {"": "BackboneFuntimes"},
	
	initialize: function(){
		this.mapView = new App.MapView({ mapProvider: new App.MapProviders.Leaflet() });
	},

	start: function(){
		Backbone.history.start();
	},
}));

$(App.start());