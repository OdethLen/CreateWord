using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;
namespace CreateWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document|*.docx";
            saveFileDialog.Title = "WORD DOCUMENTTT";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(saveFileDialog.FileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart MainPart = wordDocument.AddMainDocumentPart();
                MainPart.Document = new Document();
                Body body = MainPart.Document.AppendChild(new Body());
                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text(txtDoc.Text));
                wordDocument.Save();
            }

            MessageBox.Show("Word document saved :D");

        }


    }
}
