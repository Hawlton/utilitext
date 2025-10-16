using System.Diagnostics;
using System.Text;

namespace utilitext
{
    public partial class Form1 : Form
    {
        private string? current_file_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private Encoding current_encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
        private bool modified = false;
        public Form1()
        {
            InitializeComponent();
            HashTab.Controls.Add(new HasherControl() { Dock = DockStyle.Fill });
        }

        private void EditorLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using var open_file_dialog = new OpenFileDialog
                {
                    Title = "Open Text File",
                    Filter = "Text Files (*.txt;*.md;*.csv;*.log;*.xml;*.json)|*.txt;*.md;*.csv;*.log;*.xml;*.json|All Files (*.*)|*.*",
                    CheckFileExists = true,
                    RestoreDirectory = true,
                    InitialDirectory = current_file_path
                };

                //if (!string.IsNullOrWhiteSpace(current_file_path))
                //{
                //    var dir = Path.GetDirectoryName(current_file_path);
                //    if (dir != null && Directory.Exists(dir))
                //    {
                //        open_file_dialog.InitialDirectory = dir;
                //    }
                //}
                if(open_file_dialog.ShowDialog(this) == DialogResult.OK)
                {
                    current_file_path = open_file_dialog.FileName;
                    load_file(open_file_dialog.FileName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(current_file_path))
                {
                    save_as_clicked(sender!, e);
                    return;
                }
                save_file(current_file_path);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void save_as_clicked(object sender, EventArgs e)
        {
            try
            {
                using var save_file_dialog = new SaveFileDialog
                {
                    Title = "Save Text File As",
                    Filter = "Text Files (*.txt;*.md;*.csv;*.log;*.xml;*.json)|*.txt;*.md;*.csv;*.log;*.xml;*.json|All Files (*.*)|*.*",
                    RestoreDirectory = true,
                    AddExtension = true,
                };
                if(save_file_dialog.ShowDialog(this) == DialogResult.OK)
                {
                    save_file(save_file_dialog.FileName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void save_file(string path)
        {
            using var writer = new StreamWriter(path, false, current_encoding);
            writer.Write(EditorBox.Text);
            current_file_path = path;
            EditorPath.Text = path;
            modified = true;
        }

        private void load_file(string file_path)
        {
            try
            {
                using var file_stream = File.OpenRead(file_path);
                using var reader = new StreamReader(file_stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
                var content = reader.ReadToEnd();

                current_encoding = reader.CurrentEncoding;
                current_file_path = file_path;
                EditorPath.Text = file_path;
                EditorBox.Text = content;
                modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
