using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace Sothuxigon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {

            //Tìm item cần drag
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);

            if (index >= 0)
            {
                lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Link);
            }

            //Điều kiện để drag
            //Bắt đầu drag item (chỉ cần text. của item đó)
            DragDropEffects effect = lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Copy);
            
        }
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }
       
        private void listDanhsach_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                ListBox lb = (ListBox)sender;
                lb.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }
      
        private void Save(object sender, EventArgs e)
        {
            // Mở tập tin
            StreamWriter writer = new StreamWriter("danhsachthu.txt");
            if (writer == null) return; // error
            // Ghi dữ liệu vào tập tin
            foreach (var item in listDanhsach.Items)
                writer.WriteLine(item.ToString());
            // Đóng tập tin
            writer.Close();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            // Mở tập tin
            StreamReader reader = new StreamReader("Thunuoi.txt");
            if (reader == null) return;
            // Đọc từng dòng văn bản trong tập tin
            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                listThunuoi.Items.Add(input);
            }
            // Đóng tập tin
            reader.Close();
            using (StreamReader rs = new StreamReader("danhsachthu.txt"))
            {
                input = null;
                while ((input = rs.ReadLine()) != null)
                {
                    listDanhsach.Items.Add(input);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = String.Format("Bây giờ là {0}:{1}:{2} ngày {3} tháng {4} năm {5}",
            DateTime.Now.Hour,
            DateTime.Now.Minute,
            DateTime.Now.Second,
            DateTime.Now.Day,
            DateTime.Now.Month,
            DateTime.Now.Year);

        }





    }
}
