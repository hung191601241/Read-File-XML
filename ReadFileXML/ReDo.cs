using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReadFileXML
{
    public partial class ReDo : Form
    {
        public ReDo()
        {
            InitializeComponent();
        }

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            LoadFileXML();
        }

        private void LoadFileXML()
        {
            string xmlFolderPath = @"D:\02. VISION";
            string xmlFilePath = "20240711151358.xml";
            try
            {
                if (!Directory.Exists(xmlFolderPath))
                {
                    MessageBox.Show($"Folder Path {xmlFolderPath} is not exis!");
                    return;
                }
                string xmlFullPath = Path.Combine(xmlFolderPath, xmlFilePath);

                //Buffer chứa dữ liệu đọc từ file xml
                XDocument xmlDoc = XDocument.Load(xmlFullPath);

                var modules = xmlDoc.Descendants("ModuleResult").Descendants("Module");

                // Cấu hình Title ListView
                listView1.Columns.Add("ModuleId", 70);
                listView1.Columns.Add("IsSkiped", 70);
                listView1.Columns.Add("ModuleGroup", 90);
                listView1.Columns.Add("RectBottom", 120);
                listView1.Columns.Add("RectLeft", 120);
                listView1.Columns.Add("RectRight", 120);
                listView1.Columns.Add("RectTop", 120);
                listView1.Columns.Add("Result", 70);
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;

                foreach (var module in modules)
                {
                    int moduleId = (int)module.Attribute("ModuleId");
                    int isSkipped = (int)module.Attribute("IsSkiped");
                    int moduleGroup = (int)module.Attribute("ModuleGroup");
                    int rectBottom = (int)module.Attribute("RectBottom");
                    int rectLeft = (int)module.Attribute("RectLeft");
                    int rectRight = (int)module.Attribute("RectRight");
                    int rectTop = (int)module.Attribute("RectTop");
                    int result = (int)module.Attribute("Result");

                    string[] itemStr = new string[] {
                    moduleId.ToString(),
                    isSkipped.ToString(),
                    moduleGroup.ToString(),
                    rectBottom.ToString(),
                    rectLeft.ToString(),
                    rectRight.ToString(),
                    rectTop.ToString(),
                    result.ToString() };

                    //ListViewItem item = new ListViewItem(itemStr);

                    listView1.Items.Add(new ListViewItem(itemStr));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
