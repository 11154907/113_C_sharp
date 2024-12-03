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

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                //宣告變數
                decimal total = 0m;
                decimal sales;
               //tring input;

                //建立 StreamReader 物件
                StreamReader inputFile;

                //開啟檔案
                inputFile = File.OpenText("Sale.txt");

                //讀取檔案內容
                while (inputFile.EndOfStream)
                {
                    //讀取一行
                    //inout = imputFile.PeadLine();

                    //將讀取資料轉換為 decimal
                    if (decimal.TryParse(inputFile.ReadLine(), out sales))
                    {
                        //加總
                        total += sales;
                    }
                    else
                    {
                        //顯示錯誤訊息
                        MessageBox.Show("Invalid input");
                    }
                }

                //關閉檔案
                inputFile.Close();

                //顯示銷售總額
                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
