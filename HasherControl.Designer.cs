namespace utilitext
{
    partial class HasherControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hash_type_box = new ComboBox();
            hash_input_box = new TextBox();
            hash_output_box = new TextBox();
            checkBox1 = new CheckBox();
            compute_hash = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // hash_type_box
            // 
            hash_type_box.FormattingEnabled = true;
            hash_type_box.Items.AddRange(new object[] { "MD5", "SHA256" });
            hash_type_box.Location = new Point(3, 3);
            hash_type_box.Name = "hash_type_box";
            hash_type_box.Size = new Size(165, 23);
            hash_type_box.TabIndex = 0;
            // 
            // hash_input_box
            // 
            hash_input_box.Location = new Point(3, 129);
            hash_input_box.Multiline = true;
            hash_input_box.Name = "hash_input_box";
            hash_input_box.Size = new Size(666, 89);
            hash_input_box.TabIndex = 1;
            // 
            // hash_output_box
            // 
            hash_output_box.Location = new Point(3, 245);
            hash_output_box.Multiline = true;
            hash_output_box.Name = "hash_output_box";
            hash_output_box.Size = new Size(666, 153);
            hash_output_box.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(174, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "AddSalt";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // compute_hash
            // 
            compute_hash.Location = new Point(247, 3);
            compute_hash.Name = "compute_hash";
            compute_hash.Size = new Size(124, 23);
            compute_hash.TabIndex = 4;
            compute_hash.Text = "Compute Hash";
            compute_hash.UseVisualStyleBackColor = true;
            compute_hash.Click += compute_hash_clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 111);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 227);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Output";
            // 
            // HasherControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(compute_hash);
            Controls.Add(checkBox1);
            Controls.Add(hash_output_box);
            Controls.Add(hash_input_box);
            Controls.Add(hash_type_box);
            Name = "HasherControl";
            Size = new Size(672, 401);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox hash_type_box;
        private TextBox hash_input_box;
        private TextBox hash_output_box;
        private CheckBox checkBox1;
        private Button compute_hash;
        private Label label1;
        private Label label2;
    }
}
