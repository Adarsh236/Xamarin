﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin2.Models;

namespace Xamarin2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesPage : ContentPage
	{
		public NotesPage()
		{
			InitializeComponent();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ///CM
            /*/* var notes = new List<Note>();

             var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
             foreach (var filename in files)
             {
                 notes.Add(new Note
                 {
                     Filename = filename,
                     Text = File.ReadAllText(filename),
                     Date = File.GetCreationTime(filename)
                 });
             }

             listView.ItemsSource = notes
                 .OrderBy(d => d.Date)
                 .ToList();*/
            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage
            {
                BindingContext = new Note()
            });
        }

        async void ScreenClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage { });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }
    }
}