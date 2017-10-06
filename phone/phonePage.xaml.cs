using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace phone
{
    public partial class phonePage : ContentPage
    {
        public phonePage()
        {
            InitializeComponent();
            PopulatePicker();
        }

		private void PopulatePicker()
		{
			Dictionary<string, Color> nameToColor = new Dictionary<string, Color>()
			{
			{ "Aqua", Color.Aqua }, { "Black", Color.Black },
			{ "Gray", Color.Gray }, { "Green", Color.Green },
			{ "Lime", Color.Lime }, { "Maroon", Color.Maroon },
			{ "Navy", Color.Navy }, { "Olive", Color.Olive },
			{ "Purple", Color.Purple }, { "Red", Color.Red },
			{ "Silver", Color.Silver }, { "Teal", Color.Teal },
			{ "White", Color.White }, { "Yellow", Color.Yellow }
		  };


			foreach (var item in nameToColor)
			{
                theOneTruePicker.Items.Add(item.Key);
			}

            theOneTruePicker.SelectedIndex = 0;

            var mapLoc = MapSpan.FromCenterAndRadius(new Position(33,-100), Distance.FromMiles(1));
            world.MoveToRegion(mapLoc);
		}

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var random = new Random(DateTime.Now.Millisecond);
            Color randomc = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
                           
            BackgroundColor = randomc;
        }
    }
}
