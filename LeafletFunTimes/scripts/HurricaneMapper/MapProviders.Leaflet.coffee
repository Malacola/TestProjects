<<<<<<< HEAD
define (require, module) ->
	L = require 'leaflet'

	LeafletProvider = ->
		@map

		createMap: (elementId) ->
			@map = new L.Map(elementId)
			@addBaseMap()
			return @map

		addBaseMap: ->
			baseMap = new L.TileLayer("http://{s}.tiles.mapbox.com/v3/mapbox.mapbox-light/{z}/{x}/{y}.png",
				attribution: "Map data by MapBox"
				maxZoom: 18)

			@addLayer(baseMap)

		addLayer: (layer) ->
			@map.addLayer(layer)

		setView: (options) ->
			point = new L.LatLng(options.lat, options.lon)
			@map.setView(point, options.zoomLevel)

=======
define (require, module) ->
	L = require 'leaflet'

	LeafletProvider = ->
		@map

		createMap: (elementId) ->
			@map = new L.Map(elementId)
			@addBaseMap()
			return @map

		addBaseMap: ->
			baseMap = new L.TileLayer("http://{s}.tiles.mapbox.com/v3/mapbox.mapbox-light/{z}/{x}/{y}.png",
				attribution: "Map data by MapBox"
				maxZoom: 18)

			@addLayer(baseMap)

		addLayer: (layer) ->
			@map.addLayer(layer)

		setView: (options) ->
			point = new L.LatLng(options.lat, options.lon)
			@map.setView(point, options.zoomLevel)

>>>>>>> be99cb3e8cbef986f40d1b8fc00c8d89730aa711
	return LeafletProvider