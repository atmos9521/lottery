using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class drawPie : Form
    {
        private float startAngle = 0;
        private int total = 100;
        private int[] data = { 30, 20, 15, 35 };
        private string[] labels = { "部分1", "部分2", "部分3", "部分4" }; // 各部分的文字標籤
        private Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange };
        private Pen[] pens;
        private Brush[] brushes;
        public drawPie()
        {
            InitializeComponent();
            // 設置窗口的標題和大小
            this.Text = "旋轉圓餅圖示例";
            //this.Size = new Size(400, 400);
            this.DoubleBuffered = true; // 启用双缓冲以减少闪烁
            this.MouseDown += new MouseEventHandler(OnMouseDown);
            InitializePens();
        }
        private void drawPie_Load(object sender, EventArgs e)
        {
        }
        private void InitializePens()
        {
            pens = new Pen[colors.Length];
            brushes = new Brush[colors.Length];
            for (int i = 0; i < pens.Length; i++)
            {
                pens[i] = new Pen(colors[i], 2);
                brushes[i] = new SolidBrush(colors[i]);
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            // 捕捉滑鼠左鍵的單擊事件
            if (e.Button == MouseButtons.Left)
            {
                RotatePieChart();
                this.Invalidate(); // 重新繪製圓餅圖
            }
        }

        private void RotatePieChart()
        {
            // 隨機生成旋轉角度
            Random random = new Random();
            startAngle = random.Next(0, 360);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(50, 50, 300, 300);

            float currentStartAngle = startAngle;

            for (int i = 0; i < data.Length; i++)
            {
                float sweepAngle = 360f * data[i] / total;

                // 繪製部分的底色矩形
                g.FillPie(brushes[i], rect, currentStartAngle, sweepAngle);

                // 繪製圓餅圖的邊框
                g.DrawPie(pens[i], rect, currentStartAngle, sweepAngle);

                // 計算每個部分的中心角度
                float midAngle = currentStartAngle + sweepAngle / 2;

                // 計算中心點的位置，稍微調整文字位置
                float radius = rect.Width / 2 * 0.6f; // 調整文字位置，使其更接近中心
                float x = radius * (float)Math.Cos(midAngle * Math.PI / 180) + rect.Left + rect.Width / 2;
                float y = radius * (float)Math.Sin(midAngle * Math.PI / 180) + rect.Top + rect.Height / 2;


                // 在中心點位置繪製文字標籤
                g.DrawString(labels[i], new Font("Arial", 10), Brushes.Black, x - 20, y - 10);


                currentStartAngle += sweepAngle;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RotatePieChart();
            this.Invalidate(); // 重新繪製圓餅圖
        }
    }
}