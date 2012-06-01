// Generated by CoffeeScript 1.3.3
(function() {
  var CoffeeExtendedOptions, LeafletExtendedOptions, NewOptions, Options, SomeClass, SomeOtherClass, UnderScoreExtendedOptions, aLeafletClass, derp, someModule,
    __hasProp = {}.hasOwnProperty,
    __extends = function(child, parent) { for (var key in parent) { if (__hasProp.call(parent, key)) child[key] = parent[key]; } function ctor() { this.constructor = child; } ctor.prototype = parent.prototype; child.prototype = new ctor(); child.__super__ = parent.prototype; return child; };

  someModule = {};

  someModule.Util = {
    extend: function(dest) {
      var prop, source, sources, _i, _len;
      sources = Array.prototype.slice.call(arguments, 1);
      for (_i = 0, _len = sources.length; _i < _len; _i++) {
        source = sources[_i];
        for (prop in source) {
          if (!__hasProp.call(source, prop)) continue;
          dest[prop] = source[prop];
        }
      }
      return dest;
    }
  };

  SomeClass = (function() {

    function SomeClass(someProp) {
      this.someProp = someProp;
    }

    SomeClass.prototype.doSomething = function() {
      return console.log(this.someProp + ' is doing something!');
    };

    return SomeClass;

  })();

  SomeOtherClass = (function(_super) {

    __extends(SomeOtherClass, _super);

    function SomeOtherClass(someProp, someOtherProp) {
      this.someProp = someProp;
      this.someOtherProp = someOtherProp;
    }

    SomeOtherClass.prototype.doSomething = function() {
      console.log(this.someOtherProp + 'is doing something!');
      return SomeOtherClass.__super__.doSomething.apply(this, arguments);
    };

    return SomeOtherClass;

  })(SomeClass);

  aLeafletClass = lvector.Class.extend({
    options: {
      OptionA: 'OptionA',
      OptionB: 'OptionB'
    },
    initialize: function(options) {
      return lvector.Util.setOptions(this, options);
    },
    doSomething: function(val) {
      return console.log(val + ' is doing something!');
    }
  });

  derp = new aLeafletClass({
    OptionA: 'OtherOptionA'
  });

  Options = {
    BaseOptionA: null,
    BaseOptionB: null
  };

  NewOptions = {
    NewOptionB: "I'm a new option!",
    NewOptionC: "So Am I!"
  };

  CoffeeExtendedOptions = someModule.Util.extend(Options, NewOptions);

  LeafletExtendedOptions = lvector.Util.extend(Options, NewOptions);

  UnderScoreExtendedOptions = _.extend({}, Options, NewOptions);

}).call(this);