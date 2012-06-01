define (require)->
	Backbone = require 'backbone'
	EvLayer = require 'Models/EvLayer'

	MapView = Backbone.View.extend
		el: "div#map",

		initialize: ->
			@mapProvider = @options.mapProvider
			@initialCenter = @options.initialCenter or {lat: 39.937, lon: -105.0691}
			@render()

		setInitialView: ->
			@mapProvider.setView
				lat: @initialCenter.lat
				lon: @initialCenter.lon
				zoomLevel: 13

		render: ->
			@mapProvider.createMap(@el.id)
			@mapProvider.addLayer(EvLayer)
			@setInitialView()
	return MapView