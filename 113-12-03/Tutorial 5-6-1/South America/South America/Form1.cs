using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // 這裡是取得國家按鈕的點擊事件處理程式。
            try
            {
                StreamReader inputFile; //用來讀取檔案的物件
                string countryName; // 用來保存檔案中的資料
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName); //開啟檔案
                    countriesListBox.Items.Clear();
                    while (!inputFile.EndOfStream)  //當未到達檔案結尾時
                    {
                        countryName = inputFile.ReadLine(); //讀取一行資料
                        countriesListBox.Items.Add(countryName); //將資料加入 ListBox
                    }
                    inputFile.Close(); //關閉檔案

                }
                else
                {
                    MessageBox.Show("未選擇檔案!");
                }




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
