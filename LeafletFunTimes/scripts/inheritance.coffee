someModule = {}
someModule.Util =
	extend: (dest) ->
		sources = Array.prototype.slice.call(arguments, 1);
		for source in sources
			for own prop of source
				dest[prop] = source[prop]
		dest

class SomeClass
	constructor: (@someProp) ->

	doSomething: ->
		console.log( @someProp + ' is doing something!')

class SomeOtherClass extends SomeClass
	constructor: (@someProp, @someOtherProp) ->

	doSomething: ->
		console.log(@someOtherProp + 'is doing something!')
		super

aLeafletClass = lvector.Class.extend(
	options :
		OptionA: 'OptionA'
		OptionB: 'OptionB'

	initialize: (options)->
		lvector.Util.setOptions(@, options)

	doSomething: (val) ->
		console.log(val + ' is doing something!')
)

derp = new aLeafletClass
	OptionA: 'OtherOptionA'

Options = 
	BaseOptionA: null
	BaseOptionB: null

NewOptions = 
	NewOptionB: "I'm a new option!"
	NewOptionC: "So Am I!"

CoffeeExtendedOptions = someModule.Util.extend(Options, NewOptions)
LeafletExtendedOptions = lvector.Util.extend(Options, NewOptions)
UnderScoreExtendedOptions = _.extend({}, Options, NewOptions)