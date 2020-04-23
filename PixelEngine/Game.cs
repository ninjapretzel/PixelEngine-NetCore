using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;

namespace PixelEngine {
	
	public class Game {
		public bool init { get; private set; }

		public int ScreenWidth { get; private protected set; }
		public int ScreenHeight { get; private protected set; }
		public int PixWidth { get; private protected set; }
		public int PixHeight { get; private protected set; }

		public int FrameRate { get; private set; }
		public float FrameTime { get; private set; }
		

		internal GameWindow window;
		internal int windowWidth;
		internal int windowHeight;
		internal byte numLayers;
		private bool active;

		// Maximum Number of layers
		public const int MAX_LAYERS = 256;
		// private Sprite[] layers = new Sprite[MAX_LAYERS];
		// private readonly BitField LayerEnabled;

		public Game() {
			init = false;
			
		}

		public void Construct(int width = 100, int height = 100, int pixWidth = 5, int pixHeight = 5, int frameRate = 60) {
			ScreenWidth = width;
			ScreenHeight = height;
			PixWidth = pixWidth;
			PixHeight = pixHeight;

			windowWidth = ScreenWidth * PixWidth;
			windowHeight = ScreenHeight * PixHeight;
			numLayers = 1;

			if (frameRate > 0) {
				FrameRate = frameRate;
				FrameTime = 1000.0f / FrameRate;
			}
			
			
		}

		public void Start() {

			window = new GameWindow(windowWidth, windowHeight, GraphicsMode.Default, "PixelEngine NetCore Vidya Gaem");
			active = true;

			// gameLoop = new Thread(GameLoop);
			// gameLoop.Start();
		}
		
	}
}
