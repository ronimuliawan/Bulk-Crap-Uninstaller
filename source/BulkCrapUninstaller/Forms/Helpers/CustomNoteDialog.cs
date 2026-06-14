using System.Windows.Forms;

namespace BulkCrapUninstaller.Forms
{
    public partial class CustomNoteDialog : Form
    {
        public string NoteText
        {
            get => txtNote.Text;
            set => txtNote.Text = value;
        }

        public CustomNoteDialog(string appName, string existingNote)
        {
            InitializeComponent();
            
            // Append the app name to the localized base title
            this.Text = this.Text + appName;
            this.NoteText = existingNote;
            this.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
