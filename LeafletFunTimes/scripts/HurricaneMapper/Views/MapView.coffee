define (require)->
	Plants = require 'Models/Plants'

	MapView = Backbone.View.extend
		el: "div#map"

		initialize: ->
			@mapProvider = @options.mapProvider
			@initialCenter = @options.initialCenter or {lat: 39.937, lon: -105.0691}
			@render()

		setInitialView: ->
			@mapProvider.setView
				lat: @initialCenter.lat
				lon: @initialCenter.lon
				zoomLevel: 10

		render: ->
			@mapProvider.createMap(@el.id)
			@mapProvider.addLayer(Plants)
			@setInitialView()

	return MapView