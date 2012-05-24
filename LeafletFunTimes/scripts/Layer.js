var App = App || {};

App.Layer = Backbone.Model.extend({

	initialize: function(){
		this.layer = this.options.Layer;
	}

});