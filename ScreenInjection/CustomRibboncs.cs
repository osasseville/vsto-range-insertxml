using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace ScreenInjection
{
    public partial class CustomRibboncs
    {
        private Word.Document Document
        {
            get
            {
                return Globals.ThisAddIn.Application.ActiveDocument;
            }
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private Word.Range PromptRange()
        {
            int start, end;
            bool startOk = int.TryParse(ShowDialog("Start of the range", "(number)"), out start);
            bool endOk = int.TryParse(ShowDialog("End of the range", "(number)"), out end);

            if (!startOk || !endOk) return null;

            return Document.Range(start, end);
        }

        private void ReInjectInclusive(int start, int end)
        {
            var range = new InclusiveRange(Document.Range(start, end)).Range;
            var xml = range.WordOpenXML;
            range.InsertXML(xml);
        }

        private void CustomRibboncs_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void markButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = PromptRange();
            if (range != null)
                new InclusiveRange(range).Range.HighlightColorIndex = Word.WdColorIndex.wdBrightGreen;
        }

        private void injectButton_Click(object sender, RibbonControlEventArgs e)
        {
            var range = PromptRange();
            if (range != null)
            {
                range = new InclusiveRange(range).Range;
                var xml = range.WordOpenXML;
                range.InsertXML(xml);
            }
        }

        private void bug1Select_Click(object sender, RibbonControlEventArgs e)
        {
            new InclusiveRange(Document.Range(0, 1000)).Range.Select();
        }

        private void bug1Execute_Click(object sender, RibbonControlEventArgs e)
        {
            ReInjectInclusive(0, 1000);
        }

        private void bug2Select_Click(object sender, RibbonControlEventArgs e)
        {

            new InclusiveRange(Document.Range(123560, 125284)).Range.Select();
        }

        private void bug2Execute_Click(object sender, RibbonControlEventArgs e)
        {
            ReInjectInclusive(123560, 125284);
        }

        private void bug3Select_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
