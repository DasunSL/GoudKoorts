﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Timers;
    using view;

	public class MainController
	{
        private Timer intervalTimer;

        private int interval = 5000; // Interval in milliseconds

		public View view
		{
			get;
			set;
		}

		public MapController mapController
		{
			get;
			set;
		}

		public InputController inputController
		{
			get;
			set;
		}

		public CartsController cartsController
		{
			get;
			set;
		}

		public ShipsController shipsController
		{
			get;
			set;
		}

        public void Initialize()
        {
            // Initialize the controllers.
            view = new View(this);
            mapController = new MapController(this);
            inputController = new InputController(this);
            cartsController = new CartsController(this);
            shipsController = new ShipsController(this);

            // Render the start screen.
            view.RenderStartScreen();

            // Wait for any key to start the game.
            Console.ReadKey();

            // Start the game.
            Start();
        }

		public void Start()
		{
            // Generate the map.
            mapController.GenerateMap();

            // Render the map.
            view.RenderMap();

            // Start the interval timer.
            intervalTimer = new Timer(interval);
            intervalTimer.Elapsed += OnInterval;
            intervalTimer.AutoReset = true;
            intervalTimer.Enabled = true;

            Console.ReadKey();
		}

        private void OnInterval(Object source, ElapsedEventArgs e)
        {
            view.RenderMap();
        }
	}
}

