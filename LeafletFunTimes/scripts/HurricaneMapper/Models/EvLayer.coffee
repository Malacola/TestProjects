define ['../../EvLayer', 'PlantData'], (EvLayer, PlantData) ->
	L = require 'leaflet'

	symbologyOtions = [
		{ 
			range: [1,50] 
			vectorOptions:
				radius: 5
		},
		{
			range: [51,100]
			vectorOptions:
				radius: 20
				fillColor: "#ff7800"
		},
		{
			range: [101, 1000]
			vectorOptions: 
				radius: 35
				fillColor: "#000"
		}
	]

	plants = new EvLayer(PlantData.getPlants(),
		property: 'capacity'
		symbology: symbologyOtions
		pointToLayer: (latlng, markerOptions) -> new L.CircleMarker(latlng, markerOptions))

	return plants