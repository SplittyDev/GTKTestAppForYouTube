using System;
using WF = System.Windows.Forms;

using Gtk;

public partial class MainWindow : Gtk.Window {
    public MainWindow () : base (Gtk.WindowType.Toplevel) {
        Build ();
    }

    protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
        Application.Quit ();
        a.RetVal = true;
    }

    protected void OnBtnCalculateClicked (object sender, EventArgs e) {
        var txtOne = entryOne.Text;
        var txtTwo = entryTwo.Text;

        int txtOneResult;
        if (!int.TryParse (txtOne, out txtOneResult)) {
            WF.MessageBox.Show ($"{txtOne} is not an integer!");
            return;
        }

        int txtTwoResult;
        if (!int.TryParse (txtTwo, out txtTwoResult)) {
            WF.MessageBox.Show ($"{txtTwo} is not an integer!");
            return;
        }

        var sum = txtOneResult + txtTwoResult;
        WF.MessageBox.Show (sum.ToString ());
    }

    protected void OnBtnPlayMp3Clicked (object sender, EventArgs e) {
        var soundPlayer = new System.Media.SoundPlayer ("test.wav");
        soundPlayer.Play ();
    }
}
