using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;

namespace ReadFileXML
{
    public partial class ReadFileXML : Form
    {
        public ReadFileXML()
        {
            InitializeComponent();
        }

        private void Btn_ReadFile_Click(object sender, EventArgs e)
        {
            LoadXmlDataToListView();
        }

        private void LoadXmlDataToListView()
        {
            // Đường dẫn đến file XML của bạn
            string xmlFolderPath = @"D:\02. VISION"; // Thay thế bằng đường dẫn thực tế của bạn
            
            try
            {
                // Kiểm tra xem file có tồn tại không
                if (!Directory.Exists(xmlFolderPath))
                {
                    MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string xmlFilePath = "20240711151358.xml";
                string xmlFullPath = Path.Combine(xmlFolderPath, xmlFilePath);
                // Load XML document
                XDocument xmlDoc = XDocument.Load(xmlFullPath);

                // Lấy tất cả các thẻ <Module> bên trong <ModuleResult>
                var modules = xmlDoc.Descendants("ModuleResult").Descendants("Module");

                // Cấu hình ListView
                ListView_XML.Columns.Add("ModuleId", 70);
                ListView_XML.Columns.Add("IsSkipped", 70);
                ListView_XML.Columns.Add("ModuleGroup", 90);
                ListView_XML.Columns.Add("RectBottom", 120);
                ListView_XML.Columns.Add("RectLeft", 120);
                ListView_XML.Columns.Add("RectRight", 120);
                ListView_XML.Columns.Add("RectTop", 120);
                ListView_XML.Columns.Add("Result", 70);
                ListView_XML.View = View.Details;
                ListView_XML.GridLines = true;
                ListView_XML.FullRowSelect = true;

                // Duyệt qua từng thẻ <Module> và đọc các thuộc tính
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

                    // Tạo ListViewItem và thêm vào ListView
                    ListViewItem item = new ListViewItem(moduleId.ToString());
                    item.SubItems.Add(isSkipped.ToString());
                    item.SubItems.Add(moduleGroup.ToString());
                    item.SubItems.Add(rectBottom.ToString());
                    item.SubItems.Add(rectLeft.ToString());
                    item.SubItems.Add(rectRight.ToString());
                    item.SubItems.Add(rectTop.ToString());
                    item.SubItems.Add(result.ToString());

                    ListView_XML.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Access to the path is denied.: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
