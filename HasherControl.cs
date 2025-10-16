using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilitext
{
    public partial class HasherControl : UserControl
    {
        public HasherControl()
        {
            InitializeComponent();
            hash_type_box.SelectedIndex = 0;
        }

        private void compute_hash_clicked(object sender, EventArgs e)
        {
            string hash_type = hash_type_box.SelectedItem.ToString() ?? "MD5";
            string input = hash_input_box.Text;
            hash_output_box.Text = ComputeHash(input, hash_type);
        }

        private string ComputeHash(string input, string hash_type)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }


    }
}
