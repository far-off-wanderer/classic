﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Far_Off_Wanderer___Classic
{
    public sealed partial class GamePage : Page
    {
        private Game game;

        public GamePage()
        {
            this.InitializeComponent();

            game = MonoGame.Framework.XamlGame<Game>.Create(string.Empty, Window.Current.CoreWindow, swapChainPanel);



            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += GamePage_BackRequested;
        }

        private void GamePage_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            game.GoBack();
        }
    }
}