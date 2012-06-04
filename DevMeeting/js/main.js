$(function() {

	window.Album = Backbone.Model.extend({
	});

	window.AlbumCollection = Backbone.Collection.extend({
		model: Album
	});

	window.AlbumView = Backbone.View.extend({
		tagName: 'li',

		initialize: function() {
			this.template = _.template($('#album-template').html())
			this.model.on('change', this.render, this);
		},

		render: function() {
			this.$el.html(this.template(this.model.toJSON()));
			return this;
		}

	});

	window.LibraryView = Backbone.View.extend({
		initialize: function () {
			this.template = _.template($("#library-template").html());
			this.collection.on('add', this.render, this);
		},

		render: function () {
			this.$el.html(this.template());
			$albums = this.$('.albums');
			this.collection.each(function (album) {
				view = new AlbumView({model: album, collection: this.collection});
				$albums.append(view.render().el);
			});
			return this;
		}

	});

	window.App = Backbone.Router.extend({
		routes: {
			"": "index",
			"simpleView" : "simpleView",
			"collection" : "collection"
		},

		initialize: function () {
			window.album = new Album({title: 'An Album', artist: 'An Artist', 
				tracks: [{title: 'Track A'}, {title: 'Track B'}]});

			window.albumView = new window.AlbumView({ model: album });

			window.albumCollection = new window.AlbumCollection();
			albumCollection.add(album);

			window.libraryView = new window.LibraryView({collection: window.albumCollection});
		},

		simpleView: function () {
			$content = $('#content');
			$content.empty();
			$content.append(window.albumView.render().el);
		},

		collection: function() {
			$content = $('#content');
			$content.empty();
			$content.append(window.libraryView.render().el);
		}
	})

	App = new App();
	Backbone.history.start();
});