using System.Collections;

namespace utilitext
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabBar = new TabControl();
            tabPage1 = new TabPage();
            EditorPath = new TextBox();
            SaveAsButton = new Button();
            SaveButton = new Button();
            EditorLoad = new Button();
            EditorBox = new TextBox();
            HashTab = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            TabBar.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TabBar
            // 
            TabBar.Controls.Add(tabPage1);
            TabBar.Controls.Add(HashTab);
            TabBar.Controls.Add(tabPage2);
            TabBar.Controls.Add(tabPage3);
            TabBar.Location = new Point(12, 12);
            TabBar.Name = "TabBar";
            TabBar.SelectedIndex = 0;
            TabBar.Size = new Size(785, 533);
            TabBar.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(EditorPath);
            tabPage1.Controls.Add(SaveAsButton);
            tabPage1.Controls.Add(SaveButton);
            tabPage1.Controls.Add(EditorLoad);
            tabPage1.Controls.Add(EditorBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 505);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Editor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditorPath
            // 
            EditorPath.Enabled = false;
            EditorPath.Location = new Point(87, 7);
            EditorPath.Name = "EditorPath";
            EditorPath.Size = new Size(371, 23);
            EditorPath.TabIndex = 4;
            // 
            // SaveAsButton
            // 
            SaveAsButton.Location = new Point(87, 35);
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(75, 23);
            SaveAsButton.TabIndex = 3;
            SaveAsButton.Text = "Save As";
            SaveAsButton.UseVisualStyleBackColor = true;
            SaveAsButton.Click += save_as_clicked;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(6, 35);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += save_clicked;
            // 
            // EditorLoad
            // 
            EditorLoad.Location = new Point(6, 6);
            EditorLoad.Name = "EditorLoad";
            EditorLoad.Size = new Size(75, 23);
            EditorLoad.TabIndex = 1;
            EditorLoad.Text = "Load";
            EditorLoad.UseVisualStyleBackColor = true;
            EditorLoad.Click += EditorLoad_Click;
            // 
            // EditorBox
            // 
            EditorBox.Location = new Point(6, 61);
            EditorBox.Multiline = true;
            EditorBox.Name = "EditorBox";
            EditorBox.Size = new Size(765, 438);
            EditorBox.TabIndex = 0;
            // 
            // HashTab
            // 
            HashTab.Location = new Point(4, 24);
            HashTab.Name = "HashTab";
            HashTab.Padding = new Padding(3);
            HashTab.Size = new Size(777, 505);
            HashTab.TabIndex = 1;
            HashTab.Text = "Hasher";
            HashTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 505);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "Key Pair Generator";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(777, 505);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Base Convert";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(TabBar);
            Name = "Form1";
            Text = "Utilitext";
            TabBar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabBar;
        private TabPage tabPage1;
        private Button SaveAsButton;
        private Button SaveButton;
        private Button EditorLoad;
        private TextBox EditorBox;
        private TabPage HashTab;
        private TextBox EditorPath;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
