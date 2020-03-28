(function (cjs, an) {

var p; // shortcut to reference prototypes
var lib={};var ss={};var img={};
lib.ssMetadata = [];


// symbols:
// helper functions:

function mc_symbol_clone() {
	var clone = this._cloneProps(new this.constructor(this.mode, this.startPosition, this.loop));
	clone.gotoAndStop(this.currentFrame);
	clone.paused = this.paused;
	clone.framerate = this.framerate;
	return clone;
}

function getMCSymbolPrototype(symbol, nominalBounds, frameBounds) {
	var prototype = cjs.extend(symbol, cjs.MovieClip);
	prototype.clone = mc_symbol_clone;
	prototype.nominalBounds = nominalBounds;
	prototype.frameBounds = frameBounds;
	return prototype;
	}


(lib.Мяч = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Слой_1
	this.shape = new cjs.Shape();
	this.shape.graphics.f().s("#FFFFFF").ss(1,1,1).p("ABaiQQAuBHATC1QAUC3g7AEQg7AFgPiLQgQiLhXheQhXhegKhKQgKhKBSAaQBSAbAYAYQAYAXAuBGg");
	this.shape.setTransform(145.1,3.5);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f().s("#000000").ss(1,1,1).p("AUoAAQAAIjmCGDQmDGCojAAQoiAAmDmCQmCmDAAojQAAoiGCmDQGDmCIiAAQIjAAGDGCQGCGDAAIig");
	this.shape_1.setTransform(68,43);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AAqChQgQiLhXheQhXhegKhKQgKhKBSAaQBSAbAYAYQAYAXAuBGQAuBHATC1QAUC3g7AEIgEABQg3AAgPiHg");
	this.shape_2.setTransform(145.1,3.5);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FF3300").s().p("AulOlQmCmCAAojQAAoiGCmCQGDmDIiAAQIjAAGDGDQGCGCAAIiQAAIjmCGCQmDGDojAAQoiAAmDmDgAJjp7QAKBKBYBeQBYBfAPCLQAQCLA7gFQA7gEgUi3QgUi2gthHQguhGgZgXQgYgYhSgbQgWgGgPAAQgrAAAHA2g");
	this.shape_3.setTransform(68,43);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_3},{t:this.shape_2},{t:this.shape_1},{t:this.shape}]}).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-65,-90,266,266);


(lib.Символ1 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Слой_1
	this.instance = new lib.Мяч("synched",0);
	this.instance.parent = this;
	this.instance.setTransform(0,0,0.189,0.189,0,0,0,68.1,43.1);

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1));

}).prototype = getMCSymbolPrototype(lib.Символ1, new cjs.Rectangle(-26,-26,52,52), null);


// stage content:
(lib.Бильярд_HTML5Canvas = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// timeline functions:
	this.frame_0 = function() {
		//
		this.movieClip_2.addEventListener("tick", fl_Animate.bind(this));
		//
		var degree = 70;
		var speed = 3;
		
		function fl_Animate(Event)
		{
			if(this.movieClip_2.x < 15)
			{
				degree = 180 - degree;
			}
			if(this.movieClip_2.x > 535)
			{
				degree = 180 - degree;
			}
			if(this.movieClip_2.y < 15)
			{
				degree = 360 - degree;
			}
			if(this.movieClip_2.y > 385)
			{
				degree = 360 - degree;
			}
			this.movieClip_2.x += Math.cos(degree*Math.PI/180)*speed;
			this.movieClip_2.y += Math.sin(degree*Math.PI/180)*speed;
		}
	}

	// actions tween:
	this.timeline.addTween(cjs.Tween.get(this).call(this.frame_0).wait(1));

	// Слой_1
	this.movieClip_2 = new lib.Символ1();
	this.movieClip_2.name = "movieClip_2";
	this.movieClip_2.parent = this;
	this.movieClip_2.setTransform(118,137.1);

	this.timeline.addTween(cjs.Tween.get(this.movieClip_2).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(367.9,312,50.2,50.2);
// library properties:
lib.properties = {
	id: 'DE86FD1BA3ABA0489E39F2A27C1764BA',
	width: 550,
	height: 400,
	fps: 60,
	color: "#FFFFFF",
	opacity: 1.00,
	manifest: [],
	preloads: []
};



// bootstrap callback support:

(lib.Stage = function(canvas) {
	createjs.Stage.call(this, canvas);
}).prototype = p = new createjs.Stage();

p.setAutoPlay = function(autoPlay) {
	this.tickEnabled = autoPlay;
}
p.play = function() { this.tickEnabled = true; this.getChildAt(0).gotoAndPlay(this.getTimelinePosition()) }
p.stop = function(ms) { if(ms) this.seek(ms); this.tickEnabled = false; }
p.seek = function(ms) { this.tickEnabled = true; this.getChildAt(0).gotoAndStop(lib.properties.fps * ms / 1000); }
p.getDuration = function() { return this.getChildAt(0).totalFrames / lib.properties.fps * 1000; }

p.getTimelinePosition = function() { return this.getChildAt(0).currentFrame / lib.properties.fps * 1000; }

an.bootcompsLoaded = an.bootcompsLoaded || [];
if(!an.bootstrapListeners) {
	an.bootstrapListeners=[];
}

an.bootstrapCallback=function(fnCallback) {
	an.bootstrapListeners.push(fnCallback);
	if(an.bootcompsLoaded.length > 0) {
		for(var i=0; i<an.bootcompsLoaded.length; ++i) {
			fnCallback(an.bootcompsLoaded[i]);
		}
	}
};

an.compositions = an.compositions || {};
an.compositions['DE86FD1BA3ABA0489E39F2A27C1764BA'] = {
	getStage: function() { return exportRoot.getStage(); },
	getLibrary: function() { return lib; },
	getSpriteSheet: function() { return ss; },
	getImages: function() { return img; }
};

an.compositionLoaded = function(id) {
	an.bootcompsLoaded.push(id);
	for(var j=0; j<an.bootstrapListeners.length; j++) {
		an.bootstrapListeners[j](id);
	}
}

an.getComposition = function(id) {
	return an.compositions[id];
}



})(createjs = createjs||{}, AdobeAn = AdobeAn||{});
var createjs, AdobeAn;