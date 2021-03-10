using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GetData();
        }

        public void GetData()
        {
            BookManager db = new BookManager(new EfBookDal());


            dataGridView1.DataSource = db.GetAll();
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["BookId"].HeaderText = "Kitap No";
            dataGridView1.Columns["PublisherId"].HeaderText = "Yayımcı No";
            dataGridView1.Columns["Language"].HeaderText = "Dil";
            dataGridView1.Columns["Shelf"].HeaderText = "Raf";
            dataGridView1.Columns["Date"].HeaderText = "Tarih";
            dataGridView1.Columns["Name"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["NumberofPage"].HeaderText = "Sayfa Sayısı";        
            dataGridView1.Columns["AuthorId"].HeaderText = "Yazar No";        

        }
    }
}
