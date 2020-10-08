using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin2.Data;

namespace Xamarin2
{
	public partial class App : Application
	{
		//public static string FolderPath { get; private set; }
		static NoteDatabase database;

		const string displayText = "displayText";

		public string DisplayText { get; set; }
		public App()
		{
			InitializeComponent();

			//MainPage = new MainPage();
			///FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
			MainPage = new NavigationPage(new NotesPage());
		}

		/// <summary>
		/// ////////////App Life Cycle-----------////////////
		/// </summary>
		protected override void OnStart()
		{
			Console.WriteLine("OnStart");

			if (Properties.ContainsKey(displayText))
			{
				DisplayText = (string)Properties[displayText];
			}
		}

		protected override void OnSleep()
		{
			Console.WriteLine("OnSleep");
			Properties[displayText] = DisplayText;
		}

		protected override void OnResume()
		{
			Console.WriteLine("OnResume");
		}
		/// <summary>
		/// /////**********-------------------************//////////
		/// </summary>
		public static NoteDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
				}
				return database;
			}
		}
	}
}
