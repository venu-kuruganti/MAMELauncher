using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows;
using Windows.UI.Popups;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MAMELauncher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnAOF_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("aof");
        }

        private async void LaunchMAME(string gameName)
        {
            ApplicationData.Current.LocalSettings.Values["gamename"] = gameName;

            try
            {
                //Launch the desktop application
                if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.FullTrustAppContract", 1, 0))
                {
                    await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("GameName");
                }
            }
            catch (Exception ex)
            {

                MessageDialog dialog = new MessageDialog(ex.Message, "Error!");
                await dialog.ShowAsync();
            }
        }

        private void btnAOF2_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("aof2");
        }

        private void btnFinalFight_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("ffightub");
        }

        private void btnAladdin_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("aladmdb");
        }

        private void btnMoonwalker_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("mwalk");
        }

        private void btnSpiderman_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("spidmanu");
        }

        private void btnKOF2000_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kof2000");
        }

        private void btnKOF2001_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kof2001");
        }

        private void btnKOF2002_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kof2002");
        }

        private void btnKOF2003_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kof2003");
        }

        private void btnBurgerTime_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("btimem");
        }

        private void btnCadillacsAndDinosaurs_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("dino");
        }

        private void btnCaptainCommando_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("captcommb");
        }

        private void btnKOF2005_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kf2k5uni");
        }

        private void btnKOFXI_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kofxi");
        }

        private void btnMoonwalker_Click_1(object sender, RoutedEventArgs e)
        {
            LaunchMAME("mwalk");
        }

        private void btnNinjaKids_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("ninjak");
        }

        private void btnSuperman_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("superman");
        }

        private void btnWH_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("wh1h");
        }

        private void btnBloodBros_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("bloodbro");
        }

        private void btnCavemanNinja_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("cninja");
        }

        private void btnDoubleDragon_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("ddragon");
        }

        private void btnRobocop2_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("robocop2u");
        }

        private void btnWWF_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("wwfmania");
        }

        private void btnAvengers_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("captavenu");
        }       

        private void btnXMen_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("xmen");
        }

        private void btnXMenvsSF_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("xmvsf");
        }

        private void btnDoubleDragonNeoGeo_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("doubledr");
        }

        private void btnThePunisher_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("punisher");
        }

        private void btnKOFXAnniv_Click(object sender, RoutedEventArgs e)
        {
            LaunchMAME("kf10thep");
        }

        private void btnSnowBros_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMarvelSuperheroes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMarvevsCapcom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMarvelvsCapcom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMarvelSHvsSF_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStreetFighterAlpha3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSuperStreetFighter2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
