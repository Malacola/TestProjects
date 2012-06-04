define ['../../EvLayer', 'PlantData'], (EvLayer, PlantData) ->
	symbologyOtions = [
		{ 
			range: [1,50] 
			vectorOptions:
				radius: 5
		},
		{
			range: [51,100]
			vectorOptions:
				radius: 10
		},
		{
			range: [101, 1000]
			vectorOptions: 
				radius: 15
		}
	]

	plants = new EvLayer(PlantData.getPlants(),
		property: 'capacity'
		symbology: symbologyOtions
		colorScheme: 'YlOrRd'
		pointToLayer: (latlng, markerOptions) ->
			if markerOptions 
				markerOptions.fillOpacity = 0.8
				markerOptions.stroke = false
			else
				markerOptions = 
					fillOpacity: 0.8
					radius: 3
					stroke: false
					fillColor: 'white'

			new L.CircleMarker(latlng, markerOptions)
		)