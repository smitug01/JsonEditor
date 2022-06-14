using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Diagnostics;
using System.Xml;
using System.Net;

namespace JsonEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox2.Visible = false;
            System.IO.Directory.CreateDirectory(programFilesPath + "\\JsonEditor");
            AppDataLocation = (programFilesPath + "\\JsonEditor");
            // MessageBox.Show(AppDataLocation);
            lang_now_button_Save = "Save\nNode";
            lang_now_button_Close = "Close\nNode";
            lang_now_button_Delete = "Delete\nNode";
            lang_now_button_Add = "Add\nNode";

            button1.Text = lang_now_button_Save;
            button2.Text = lang_now_button_Close;
            button3.Text = lang_now_button_Delete;
            button4.Text = lang_now_button_Add;
            lang_en();
        }

        string path = string.Empty;
        TreeNode choose_location;
        string tmp_backup_file = string.Empty;
        string programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string AppDataLocation = string.Empty;
        XmlTextWriter xr;

        private void DisplayTreeView(JToken root, string rootName)
        {
            treeView1.BeginUpdate();
            try
            {
                treeView1.Nodes.Clear();
                var tNode = treeView1.Nodes[treeView1.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;
                AddNode(root, tNode);
                treeView1.ExpandAll();
            }
            finally
            {
                treeView1.EndUpdate();
            }
        }

        private string ShowSaveFileDialog()
        {

            string localFilePath = String.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Json File（*.json）|*.json";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString();
                // string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); 
            }
            return localFilePath;
        }
        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            { 
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
                } 
            }
            else
            {
                Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
            }
        }

        string lang_now_File, lang_now_FileSave, lang_now_FileSaveas, lang_now_FileOpen, lang_now_FileClose, lang_now_MainFormName, lang_now_Settings, lang_now_SettingsLaguage, lang_now_SettingsViewStatus, lang_now_Help, lang_now_HelpLicense, lang_now_HelpProgramInfo, lang_now_ReportBug;

        string lang_now_label_Route, lang_now_label_Data, lang_now_label_FileLocation, lang_now_button_Save, lang_now_button_Close, lang_now_button_Delete, lang_now_button_Add;

        string lang_now_button_Save_Msg;
        public void lang_en()
        {
            //Main Part Language Packet
            lang_now_MainFormName = "Json Editor (Dev Version)";

            //File Part Language Packet
            lang_now_File = "File";
            lang_now_FileSave = "Save";
            lang_now_FileSaveas = "Save as";
            lang_now_FileOpen = "Open";
            lang_now_FileClose = "Close";

            //Setting Part Language Packet
            lang_now_Settings = "Settings";
            lang_now_SettingsLaguage = "Language";
            lang_now_SettingsViewStatus = "ViewStatus";

            //Help Part Language Packet
            lang_now_Help = "Help";
            lang_now_HelpLicense = "License";
            lang_now_ReportBug = "Report Bug";
            lang_now_HelpProgramInfo = "Program Info";

            //Page Part Language Packet
            lang_now_button_Save_Msg = "You need to choose a TreeView Node to Save.";
            lang_now_label_Route = "Route:";
            lang_now_label_Data = "Data:";
            lang_now_label_FileLocation = "File Location:";
            lang_now_button_Save = "Save\nNode";
            lang_now_button_Close = "Close\nNode";
            lang_now_button_Delete = "Delete\nNode";
            lang_now_button_Add = "Add\nNode";
        }

        public void lang_zh_tw()
        {
            //Main Part Language Packet
            lang_now_MainFormName = "Json 編輯器（非正式對外版本）";

            //File Part Language Packet
            lang_now_File = "檔案";
            lang_now_FileSave = "儲存";
            lang_now_FileSaveas = "另存新檔";
            lang_now_FileOpen = "打開";
            lang_now_FileClose = "關閉";

            //Setting Part Language Packet
            lang_now_Settings = "設定";
            lang_now_SettingsLaguage = "語言";
            lang_now_SettingsViewStatus = "檢視格式";

            //Help Part Language  Packet
            lang_now_Help = "幫助";
            lang_now_HelpLicense = "授權";
            lang_now_ReportBug = "錯誤回報";
            lang_now_HelpProgramInfo = "程式資訊";

            //Page Part Language Packet
            lang_now_button_Save_Msg = "您需要選擇節點後才可儲存。";
            lang_now_label_Route = "節點位置:";
            lang_now_label_Data = "節點資料:";
            lang_now_label_FileLocation = "檔案路徑: ";
            lang_now_button_Save = "儲存\n節點";
            lang_now_button_Close = "關閉\n節點";
            lang_now_button_Delete = "刪除\n節點";
            lang_now_button_Add = "新增\n節點";
        }

        public void apply_lang()
        {
            //Main Part Apply
            this.Text = lang_now_MainFormName;

            filesToolStripMenuItem.Text = lang_now_File;
            saveToolStripMenuItem.Text = lang_now_FileSave;
            saveAsToolStripMenuItem.Text = lang_now_FileSaveas;
            openToolStripMenuItem.Text = lang_now_FileOpen;
            closeToolStripMenuItem.Text = lang_now_FileClose;

            settingsToolStripMenuItem.Text = lang_now_Settings;
            languageToolStripMenuItem.Text = lang_now_SettingsLaguage;
            viewStatusToolStripMenuItem.Text = lang_now_SettingsViewStatus;

            helpToolStripMenuItem.Text = lang_now_Help;
            licencesToolStripMenuItem.Text = lang_now_HelpLicense;
            reportBugToolStripMenuItem.Text = lang_now_ReportBug;
            programInfoToolStripMenuItem.Text = lang_now_HelpProgramInfo;

            label2.Text = lang_now_label_Route;
            label3.Text = lang_now_label_Data;
            label1.Text = lang_now_label_FileLocation;
            button1.Text = lang_now_button_Save;
            button2.Text = lang_now_button_Close;
            button3.Text = lang_now_button_Delete;
            button4.Text = lang_now_button_Add;
        }

        /* view_status = 1 => text view
         * view_status = 0 => tree view 
         * default "tree view" */

        int view_status = 0;
        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string XmlToJsonApi(string xml)
        {
            var post = "https://api.factmaven.com/xml-to-json?xml=" + xml;
            WebRequest request = WebRequest.Create(post);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            return responseFromServer;
        }
        public class NodeTag
        {
            public string NodeName;
            public string NodeFunc;
            public int NodeNumber;
            public DataRow datarow;
        }

        private void saveNode2(TreeNodeCollection tnc)
        {
            foreach (TreeNode node in tnc)
            {
                //If we have child nodes, we'll write 
                //a parent node, then iterrate through
                //the children

                if (node.Nodes.Count > 0)
                {
                    xr.WriteStartElement(node.Text);
                    saveNode2(node.Nodes);
                    xr.WriteEndElement();
                }
                else //No child nodes, so we just write the text
                {
                    xr.WriteString(node.Text);


                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_status == 0)
            {
                xr = new XmlTextWriter(AppDataLocation + "\\treeview.xml", System.Text.Encoding.UTF8);
                xr.WriteStartDocument();
                //Write our root node
                xr.WriteStartElement(treeView1.Nodes[0].Text);
                foreach (TreeNode node in treeView1.Nodes)
                {
                    saveNode2(node.Nodes);
                }
                //Close the root node
                xr.WriteEndElement();
                xr.Close();

                var xml = File.ReadAllText(AppDataLocation + "\\treeview.xml");
                // MessageBox.Show(responseFromServer);
                if (textBox1.Text != null)
                {
                    File.WriteAllTextAsync(path, XmlToJsonApi(xml));
                }
                else
                {
                    try
                    { File.WriteAllTextAsync(ShowSaveFileDialog(), XmlToJsonApi(xml)); }
                    catch { }
                }
            }
            else if (view_status == 1)
            {
                var data = string.Empty;
                path = textBox1.Text;
                data = richTextBox2.Text;
                if (textBox1.Text != null)
                {
                    File.WriteAllTextAsync(path, data);
                }
                else
                {
                    try { File.WriteAllTextAsync(ShowSaveFileDialog(), data); }
                    catch { }
                }
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (choose_location != null) choose_location.Remove();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_status == 0)
            {
                xr = new XmlTextWriter(AppDataLocation + "\\treeview.xml", System.Text.Encoding.UTF8);
                xr.WriteStartDocument();
                //Write our root node
                xr.WriteStartElement(treeView1.Nodes[0].Text);
                foreach (TreeNode node in treeView1.Nodes)
                {
                    saveNode2(node.Nodes);
                }
                //Close the root node
                xr.WriteEndElement();
                xr.Close();

                var xml = File.ReadAllText(AppDataLocation + "\\treeview.xml");
                // MessageBox.Show(responseFromServer);
                File.WriteAllTextAsync(ShowSaveFileDialog(), XmlToJsonApi(xml));
            }
            else if (view_status == 1)
            {
                var data = string.Empty;
                path = textBox1.Text;
                data = richTextBox2.Text;
                File.WriteAllTextAsync(ShowSaveFileDialog(), data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            textBox1.Text = String.Empty;
            choose_location = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void reportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpProgramInfo frm = new HelpProgramInfo();
            frm.Show();
        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpProgramInfo frm = new HelpProgramInfo();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (choose_location != null)
            {
            choose_location.Nodes.Add(richTextBox1.Text);
            }
            else
            {
                treeView1.Nodes.Add(richTextBox1.Text);
            }
        }


        private void licencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpLicense form = new HelpLicense();
            form.Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang_en();
            apply_lang();
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang_zh_tw();
            apply_lang();
        }

        //Default using TreeView.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select file";
                dialog.InitialDirectory = ".\\";
                dialog.Filter = "json files (*.*)|*.json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = System.IO.Path.GetFullPath(dialog.FileName);
                    textBox1.Text = path;

                    if (view_status == 0)
                    {
                        TreeViewReadFile(path);
                    }
                    else if (view_status == 1)
                    {
                        TextViewReadFile(path);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Can't Open that file, Error Code: " + ex.ToString); }
        }

        private void TreeViewReadFile(string path)
        {
                using (var reader = new StreamReader(path))
                using (var jsonReader = new JsonTextReader(reader))
                {
                    var root = JToken.Load(jsonReader);
                    DisplayTreeView(root, Path.GetFileNameWithoutExtension(path));
                }
        }

        private void TextViewReadFile(string path)
        {
            string data = File.ReadAllText(path);
            richTextBox2.Text = data;
            view_status = 1;
        }
        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBox1.Text = e.Node.Text;
            textBox2.Text = e.Node.FullPath;
            choose_location = treeView1.GetNodeAt(e.X, e.Y);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* view_status = 1 => text view
 *          view_status = 0 => tree view 
 *          default "tree view" */
            try
            {
                choose_location.Text = richTextBox1.Text;
            }
            catch
            {
                MessageBox.Show(lang_now_button_Save_Msg);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_status != 0)
            {
                // Save file before switch view status. (*check richtextbox data status)
                if (richTextBox2.Text != null)
                {
                    var data = richTextBox2.Text; var tmp_path = (AppDataLocation + "\\transfer.json");
                    File.WriteAllTextAsync(tmp_path, data);
                    Thread.Sleep(500);
                    TreeViewReadFile(tmp_path);
                }

                treeView1.Visible = true;
                richTextBox2.Visible = false;

                label4.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;

                if (textBox1.Text != "" && richTextBox2.Text == null)
                {
                    path = textBox1.Text;
                    TreeViewReadFile(path);
                    view_status = 0;
                }
                else
                {
                    view_status = 0;
                }
            }
        }

        private void textViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_status != 1)
            {
                if (treeView1.Nodes.Count != 0)
                {
                    xr = new XmlTextWriter(AppDataLocation + "\\treeview.xml", System.Text.Encoding.UTF8);
                    xr.WriteStartDocument();
                    //Write our root node
                    xr.WriteStartElement(treeView1.Nodes[0].Text);
                    foreach (TreeNode node in treeView1.Nodes)
                    {
                        saveNode2(node.Nodes);
                    }
                    //Close the root node
                    xr.WriteEndElement();
                    xr.Close();

                    var xml = File.ReadAllText(AppDataLocation + "\\treeview.xml");
                    // MessageBox.Show(responseFromServer);
                    richTextBox2.Text = XmlToJsonApi(xml);

                }

                treeView1.Visible = false;
                richTextBox2.Visible = true;

                label4.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;

                if (textBox1.Text != "")
                {
                    string path = textBox1.Text;
                    TextViewReadFile(path);

                }
                else view_status = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}