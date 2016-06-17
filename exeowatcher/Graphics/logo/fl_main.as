package  
{
	import flash.events.MouseEvent;
	import com.greensock.*; 
	import com.greensock.easing.*;
	import com.greensock.plugins.*;
	import flash.display.MovieClip;
	import flash.utils.*;
	
	public class fl_main extends MovieClip
	{
		public var i_aText_a : MovieClip;
		public var i_aText_b : MovieClip;
		public var i_Sun     : MovieClip;
		public var i_Sun_b   : MovieClip;
		public var i_Owl     : MovieClip;

		
		public function fl_main()
		{
			var atext_x : int = 85;
			var atext_y : int = 40;
			
			var sun_x : int = 150;
			var sun_y : int = 15;
			
			var owl_x : int = 180;
			var owl_y : int = 40;
			
			//
			
			i_aText_a = new sy_aText_a();
			i_aText_a.x = atext_x;
			i_aText_a.y = atext_y;
			i_aText_a.alpha = 1;
			addChild(i_aText_a);
			i_aText_a.addEventListener( MouseEvent.MOUSE_OVER, aText_a_onmouseover );
			
			i_aText_b = new sy_aText_b();
			i_aText_b.x = atext_x;
			i_aText_b.y = atext_y;
			i_aText_b.alpha = 0;
			addChild(i_aText_b);
			i_aText_b.addEventListener(MouseEvent.MOUSE_OUT, aText_b_onmouseout);
			i_aText_b.addEventListener(MouseEvent.CLICK, action_onmouseclick);
			
			i_Sun = new sy_Sun();
			i_Sun.x = sun_x;
			i_Sun.y = sun_y;
			i_Sun.alpha = 1;
			addChild(i_Sun);
			
			i_Sun_b = new sy_Sun_b();
			i_Sun_b.x = sun_x;
			i_Sun_b.y = sun_y;
			i_Sun_b.alpha = 0;
			addChild(i_Sun_b);
			
			i_Owl = new sy_Owl();
			i_Owl.x = owl_x;
			i_Owl.y = owl_y;
			i_Owl.alpha = 1;
			addChild(i_Owl);
			i_Owl.addEventListener(MouseEvent.CLICK, action_onmouseclick);
			
			//
			
			proceed();
		}
		
		function aText_a_onmouseover(e:MouseEvent):void
		{
			TweenMax.to(  i_aText_b, 0.4, { autoAlpha:1 } ); 
			TweenMax.to(  i_Sun_b, 0.4, { autoAlpha:1 } ); 
		}
		
		function aText_b_onmouseout(e:MouseEvent):void
		{
			TweenMax.to(  i_aText_b, 0.4, { autoAlpha:0 } );
			TweenMax.to(  i_Sun_b, 0.4, { autoAlpha:0 } ); 
		}
		
		function action_onmouseclick(e:MouseEvent):void
		{
			proceed();
		}
		
		//
		
		function proceed() : void
		{
			TweenMax.to(  i_Owl, 0.1, { scaleX:1.2, scaleY:1.2, onComplete:proceed_done } ); 
			
			TweenMax.to(  i_aText_b, 0.1, { autoAlpha:1 } ); 
			
			TweenMax.to(  i_Sun_b, 0.1, { autoAlpha:1 } ); 
		}
		
		function proceed_done() : void
		{
			TweenMax.to(  i_Owl, 0.1, { scaleX:1, scaleY:1 } ); 
			
			TweenMax.to(  i_aText_b, 0.1, { autoAlpha:0 } ); 
			
			TweenMax.to(  i_Sun_b, 0.1, { autoAlpha:0 } ); 
		}
	}
	
}
