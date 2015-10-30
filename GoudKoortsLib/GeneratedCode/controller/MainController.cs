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
	using view;

	public class MainController
	{
		public virtual View view
		{
			get;
			set;
		}

		public virtual MapController mapController
		{
			get;
			set;
		}

		public virtual InputController inputController
		{
			get;
			set;
		}

		public virtual CartsController cartsController
		{
			get;
			set;
		}

		public virtual ShipsController shipsController
		{
			get;
			set;
		}

        public MainController()
        {
            view = new View(this);
            mapController = new MapController(this);
            inputController = new InputController(this);
            cartsController = new CartsController(this);
            shipsController = new ShipsController(this);
        }

		public virtual void Start()
		{
            
		}

	}
}

