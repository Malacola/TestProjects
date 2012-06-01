<<<<<<< HEAD
requirejs.config
	baseUrl: "scripts/HurricaneMapper"
	paths:
		'jquery'     : 'https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min'
		'underscore' : '../lib/underscore/underscore'
		'backbone'   : '../lib/backbone/backbone'
		'leaflet'    : '../lib/leaflet/leaflet-src'
		'PlantData'  : '../../data/plants'
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

require ['app', 'jquery'], (App, $) ->
=======
requirejs.config
	baseUrl: "scripts/HurricaneMapper"
	paths:
		'jquery'     : 'https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min'
		'underscore' : '../lib/underscore/underscore'
		'backbone'   : '../lib/backbone/backbone'
		'leaflet'    : '../lib/leaflet/leaflet-src'
		'PlantData'  : '../../data/plants'
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

require ['app', 'jquery'], (App, $) ->
>>>>>>> be99cb3e8cbef986f40d1b8fc00c8d89730aa711
	$ -> App.start()