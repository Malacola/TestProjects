<<<<<<< HEAD
define (require, exports, module) ->
	$               = require 'jquery'
	MapView         = require 'Views/MapView'
	Backbone        = require 'backbone'
	LeafletProvider = require 'MapProviders.Leaflet'

	class AppRouter extends Backbone.Router
		routes: 
			"": "HurricaneMapper"

		initialize: ->
			@mapView = new MapView(mapProvider: new LeafletProvider())

=======
define (require, exports, module) ->
	$               = require 'jquery'
	MapView         = require 'Views/MapView'
	Backbone        = require 'backbone'
	LeafletProvider = require 'MapProviders.Leaflet'

	class AppRouter extends Backbone.Router
		routes: 
			"": "HurricaneMapper"

		initialize: ->
			@mapView = new MapView(mapProvider: new LeafletProvider())

>>>>>>> be99cb3e8cbef986f40d1b8fc00c8d89730aa711
	module.exports = {AppRouter: AppRouter}