using DevTest.HttpServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTest
{
    public partial class UrlMapForm : Form
    {
        public UrlMap UrlMap { get; set; }
        public UrlMapForm()
        {
            InitializeComponent();
        }

        public void Render()
        {
            this.textBox1.Text = UrlMap.Host;
            this.textBox2.Text = UrlMap.Url;
            this.textBox3.Text = UrlMap.OldIp;
            this.textBox4.Text = UrlMap.NewIp;
            this.checkBox1.Checked = UrlMap.Used;
        } 

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty( this.textBox1.Text))
            {
                MessageBox.Show("请输入【域名】！");
            }
            if (String.IsNullOrEmpty(this.textBox3.Text))
            {
                MessageBox.Show("请输入【旧IP+端口】！");
            }
            if (String.IsNullOrEmpty(this.textBox3.Text))
            {
                MessageBox.Show("请输入【新IP+端口】！");
            }

            UrlMap.Host = this.textBox1.Text;
            UrlMap.Url = this.textBox2.Text;
            UrlMap.OldIp = this.textBox3.Text;
            UrlMap.NewIp = this.textBox4.Text;
            UrlMap.Used = this.checkBox1.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {


            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



    }
}
