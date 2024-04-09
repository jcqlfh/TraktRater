using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace TraktRater.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void txtTraktPinCode_Click(object sender, PointerPressedEventArgs args)
    { }

    public void txtTraktPinCode_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void lnkTraktOAuth_LinkClicked(object sender, RoutedEventArgs args)
    { }

    public void pbPaypal_Click(object sender, PointerPressedEventArgs args)
    { }

    public void lnkPaypal_LinkClicked(object sender, RoutedEventArgs args)
    { }

    public void chkTVDbEnabled_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtTVDbAccountId_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void chkTMDbEnabled_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void chkTMDbSyncWatchlist_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void lnkTMDbStart_LinkClicked(object sender, RoutedEventArgs args)
    { }

    public void chkIMDbEnabled_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void btnImdbDeleteList_Click(object sender, RoutedEventArgs args)
    { }

    public void btnImdbAddList_Click(object sender, RoutedEventArgs args)
    { }

    public void chkImdbWatchlist_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtImdbWatchlistFile_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void btnImdbWatchlistBrowse_Click(object sender, RoutedEventArgs args)
    { }

    public void txtImdbWebUsername_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void rdnImdbCSV_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtImdbRatingsFilename_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void btnImdbRatingsBrowse_Click(object sender, RoutedEventArgs args)
    { }

    public void chkListalEnabled_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtListalShowXMLExport_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void btnListalShowXMLExport_Click(object sender, RoutedEventArgs args)
    { }

    public void lnkListalExport_LinkClicked(object sender, RoutedEventArgs args)
    { }

    public void chkListalWebWatchlist_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtListalMovieXMLExport_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void btnListalMovieXMLExport_Click(object sender, RoutedEventArgs args)
    { }

    public void chkFlixsterEnabled_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtFlixsterUserId_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void chkFlixsterSyncWantToSee_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void chkCritickerEnabled_CheckedChanged(object sender, RoutedEventArgs args)
    { }

    public void txtCritickerCSVExportFile_TextChanged(object sender, AvaloniaPropertyChangedEventArgs args)
    { }

    public void btnCritickerCSVExportBrowse_Click(object sender, RoutedEventArgs args)
    { }
}