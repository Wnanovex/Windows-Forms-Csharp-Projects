using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Text_Editor.frmTextEditor;

namespace Text_Editor
{
    public partial class frmTextEditor: Form
    {
        public frmTextEditor() {
            InitializeComponent();
            undoManager.Push("");
        }

        private class TextFileManager {
            public TextFileManager(string filePath) {
                if(filePath == null) return;
                //throw new ArgumentNullException(nameof(filePath));

                bool fileExists = File.Exists(filePath);
                if (!fileExists)
                    File.Create(filePath).Close();

                this.filePath = filePath;
            }
            public readonly string filePath;

            public bool isEmpty() {
                return string.IsNullOrEmpty(filePath);
            }

            public void AddDataToFile(string Data) {
                try{
                    StreamWriter sw = File.CreateText(filePath);
                    sw.Write(Data);
                    sw.Close();
                }catch (Exception ex) {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public string ReadDataFromFile() {
                StringBuilder data = new StringBuilder();
                try {
                    StreamReader sr = File.OpenText(filePath);
                    string line = sr.ReadLine();
                    while (line != null) {
                        data.AppendLine(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }catch (Exception ex) {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return data.ToString().TrimEnd(Environment.NewLine.ToCharArray());
            }

        }

        public class UndoManager {
            private Stack<string> undoStack = new Stack<string>();
            private Stack<string> redoStack = new Stack<string>();

            public void Push(string text) {
                undoStack.Push(text);
                redoStack.Clear();  // Clear redo stack on new input
            }

            public void Clear() {
                undoStack.Clear();
                redoStack.Clear();
            }

            public string Peek() {
                return undoStack.Peek();
            }

            public string Undo() {
                if (undoStack.Count > 1) {
                    string undoText = undoStack.Pop();
                    redoStack.Push(undoText);
                    return undoStack.Peek();
                }
                return null;
            }

            public string Redo() {
                if (redoStack.Count > 0) {
                    string redoText = redoStack.Pop();
                    undoStack.Push(redoText);
                    return redoText;
                }
                return null;
            }
        }

        TextFileManager textFileManager = new TextFileManager(null);
        UndoManager undoManager = new UndoManager();
        private const string DefaultDirectory = @"C:\";
        private const string FileFilter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        private const string DefaultExt ="txt";

        private void ConfigureFileDialog(FileDialog dialog, string title, string defaultExt = DefaultExt, string filter = FileFilter) {
            dialog.InitialDirectory = DefaultDirectory;
            dialog.Title = title;
            dialog.Filter = filter;
            dialog.DefaultExt = defaultExt;
        }

        public void UpdateText(string text) {
            richTextBox1.Text = text;
        }

        private void HandleOpenFileMenuItem() {
            ConfigureFileDialog(openFileDialog1, "Open your file");

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                textFileManager = new TextFileManager(openFileDialog1.FileName);
                UpdateText(textFileManager.ReadDataFromFile());
                this.Text = "Text Editor - " + openFileDialog1.SafeFileName;
                // Clear stacks when opening a new file
                undoManager.Clear();
                undoManager.Push(richTextBox1.Text); // Save the initial state
            }
        }

        private void HandleCreateNewFileMenuItem() {
            ConfigureFileDialog(openFileDialog1, "New");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                textFileManager = new TextFileManager(saveFileDialog1.FileName);
                this.Text = "Text Editor - " + openFileDialog1.SafeFileName;
                // Clear stacks when creating a new file
                undoManager.Clear();
                undoManager.Push(richTextBox1.Text); // Save the initial state
            }
        }

        private void HandleSaveAsMenuItem() {
            ConfigureFileDialog(openFileDialog1, "Save As");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                textFileManager = new TextFileManager(saveFileDialog1.FileName);
                textFileManager.AddDataToFile(richTextBox1.Text);
                this.Text = "Text Editor - " + openFileDialog1.SafeFileName;
            }
        }

        private void HandleSaveMenuItem() {
            if (textFileManager.isEmpty()) {
                MessageBox.Show("Cannot save because you are not openning file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textFileManager.AddDataToFile(richTextBox1.Text);
        }

        private void HandleUndoMenuItem() {
            string undoText = undoManager.Undo();
            if (undoText != null)
                UpdateText(undoText);
        }

        private void HandleRedoMenuItem() {
            string redoText = undoManager.Redo();
            if (redoText != null)
                UpdateText(redoText);
        }

        private void HandleCutMenuItem() {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText)) {
                Clipboard.SetText(richTextBox1.SelectedText); // Cut the selected text and place it in the clipboard
                richTextBox1.SelectedText = ""; // Remove the selected text from the TextBox
            }else {
                MessageBox.Show("Nothing to cut.", "Cut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HandleCopyMenuItem() {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
                Clipboard.SetText(richTextBox1.SelectedText); // Copy the selected text to the clipboard
            else
                MessageBox.Show("Nothing to copy.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HandlePasteMenuItem() {
            if (Clipboard.ContainsText())
                richTextBox1.SelectedText = Clipboard.GetText(); // Paste the clipboard text at the current cursor position
            else
                MessageBox.Show("Clipboard is empty or contains non-text data.", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HandleSelectAllMenuItem() {
            richTextBox1.SelectAll(); // Select all the text in the TextBox
        }

        private void HandleWordWrapMenuItem() {
            if (wordwrapToolStripMenuItem.Checked)
                richTextBox1.WordWrap = true;
            else
                richTextBox1.WordWrap = false;
        }

        private void HandleFontMenuItem() {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;

            fontDialog1.Font = richTextBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void HandleFontColorMenuItem() {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void HandleBackColorMenuItem() {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = colorDialog1.Color;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleOpenFileMenuItem();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e) {
            HandleCreateNewFileMenuItem();
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleSaveAsMenuItem();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleSaveMenuItem();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (richTextBox1.Text != undoManager.Peek())
                undoManager.Push(richTextBox1.Text);  // Push current text into undo stack whenever text changes
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleUndoMenuItem();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleRedoMenuItem();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleCutMenuItem();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleCopyMenuItem();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            HandlePasteMenuItem();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleSelectAllMenuItem();
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleWordWrapMenuItem();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleFontMenuItem();
        }

        private void fontDialog1_Apply(object sender, EventArgs e) {
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleFontColorMenuItem();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e) {
            HandleBackColorMenuItem();
        }
    }
}
