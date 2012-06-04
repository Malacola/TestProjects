requirejs.config
	baseUrl: "scripts/HurricaneMapper"
	paths:
		'jquery'     : 'https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min'
		'underscore' : '../lib/underscore/underscore'
		'backbone'   : '../lib/backbone/backbone'
		'leaflet'    : '../lib/leaflet/leaflet-src'
		'PlantData'  : '../../data/plants'
		'ColorBrewer': '../ColorBrewer'
	shim:
		'app'        : ['jquery']
		'underscore' : 
			exports: '_'
		'backbone'   : 
			deps: ['underscore']
			exports: 'Backbone'
		'leaflet'    :
			exports: 'L'
		'PlantData'  :
		    exports: 'PlantData'
		'ColorBrewer':
			exports: 'ColorBrewer'

require ['app', 'jquery'], (App, $) ->
	$ -> App.start()