<<<<<<< HEAD
define (require, exports, module) ->
	$        = require 'jquery'
	Backbone = require 'backbone'
	router   = require 'router'

	AppRouter = router.AppRouter

	App =
		start: ->
			new AppRouter()
=======
define (require, exports, module) ->
	$        = require 'jquery'
	Backbone = require 'backbone'
	router   = require 'router'

	AppRouter = router.AppRouter

	App =
		start: ->
			new AppRouter()
>>>>>>> be99cb3e8cbef986f40d1b8fc00c8d89730aa711
			Backbone.history.start(pushState: true)