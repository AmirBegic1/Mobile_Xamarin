using AmirBegic.Tables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmirBegic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        

        public Register()
        {
            InitializeComponent();
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);

            db.CreateTable<RegUserTable>();


            var item = new RegUserTable()
            {
                Username = EntryUsernameRegister.Text,
                Password = EntryPasswordRegister.Text,
                ConfirmPasswword = EntryConfrimPassword.Text
            };

            db.Insert(item);

            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("CESTITAMO", "registracija korisnika uspjesna! ", "Yes", "Cancel");
            });




            if (EntryPasswordRegister.Text == EntryConfrimPassword.Text)
            {
                Navigation.PushAsync(new MainPage());
            }
            else {
                DisplayAlert("ERROR", "Passowrdi se ne popdudraju", "Cancel");
            }

            
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {




            Navigation.PushAsync(new Login());
        }

        private object SqlLiteConnection(string dbpath)
        {
            throw new NotImplementedException();
        }
    }
}